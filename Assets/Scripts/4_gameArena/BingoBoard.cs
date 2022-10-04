using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;

public class BingoBoard : MonoBehaviour, IPointerClickHandler
{
    Problem problem;

    Dividend dividend;
    Divisor divisor;
    Quotient quotient;

    GameOver gameover;
    
    string mytmptext;
    public static int i;
    public static int count = 25;

    public static int currentquotient;

    public void Awake()
    {
      
    }

    public void OnPointerClick(PointerEventData eventData)
    {

        if (mytmptext == Convert.ToString(currentquotient))
        {
            Debug.Log(true);
            GetComponent<TMP_Text>().color = Color.green;
            problem.dividendlist.RemoveAt(i);
            problem.answerslist.RemoveAt(i);

        }
        else
        {
            Debug.Log(false);
            string temp = GetComponent<TMP_Text>().text;
            int inttemp = Convert.ToInt32(temp);
            Destroy(GetComponent<TMP_Text>());
            
            int j = problem.answerslist.IndexOf(inttemp);
            problem.dividendlist.RemoveAt(j);
            problem.answerslist.RemoveAt(j);
        }

        i = UnityEngine.Random.Range(0, problem.dividendlist.Count);

        if(problem.dividendlist.Count > 0)
        {
            dividend.GetComponent<TMP_Text>().text = problem.dividendlist[i].ToString();
            divisor.GetComponent<TMP_Text>().text = problem.divisor.ToString();
            currentquotient = problem.dividendlist[i] / problem.divisor;
            quotient.GetComponent<TMP_Text>().text = currentquotient.ToString();
        }
        else
        {
            Debug.Log("Game Over!");
            gameover.GetComponent<TMP_Text>().enabled = true;
            
        }
    }

    private void OnEnable()
    {
        problem = GameObject.Find("Problem").GetComponent<Problem>();
        dividend = GameObject.Find("dividend").GetComponent<Dividend>();
        divisor = GameObject.Find("divisor").GetComponent<Divisor>();
        quotient = GameObject.Find("quotient").GetComponent<Quotient>();
        gameover = GameObject.Find("GameOver").GetComponent<GameOver>();
    }


    // Start is called before the first frame update
    void Start()
    {
        mytmptext = GetComponent<TMP_Text>().text.ToString();

        i = UnityEngine.Random.Range(0, problem.dividendlist.Count);

        dividend.GetComponent<TMP_Text>().text = problem.dividendlist[i].ToString();
        divisor.GetComponent<TMP_Text>().text = problem.divisor.ToString();
        currentquotient = problem.dividendlist[i] / problem.divisor;
        quotient.GetComponent<TMP_Text>().text = currentquotient.ToString();

        gameover.GetComponent<TMP_Text>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
