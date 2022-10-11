using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class BingoBoard : MonoBehaviour, IPointerClickHandler
{
    Problem problem;
    Calculation calculation;
    
    private string mytmptext;
    private int currentquotient;
    private string index;
    private int inttemp;

    // Start is called before the first frame update
    void Start()
    {
        problem = GameObject.Find("Problem").GetComponent<Problem>();
        calculation = GameObject.Find("CalculationSingleton").GetComponent<Calculation>();
        mytmptext = GetComponent<TMP_Text>().text.ToString();

        index = this.name;
        inttemp = Convert.ToInt32(index);
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        currentquotient = calculation.currentquotient;

        if (mytmptext == Convert.ToString(currentquotient))
        {
            Debug.Log(true);
            Debug.Log(index);
            GetComponent<TMP_Text>().color = Color.green;
            //problem.dividendlist.RemoveAt(calculation.i);
            //problem.answerslist.RemoveAt(calculation.i);

            //problem.dividendlist[calculation.i] = 00;
            //problem.answerslist[calculation.i] = 00;

            problem.dividendlist[inttemp] = 00;
            problem.answerslist[inttemp] = 00;

            displayToLog();
            calculation.updateProblem();
        }
        else
        {
            Debug.Log(false);
            Debug.Log(index);
            //int inttemp = Convert.ToInt32(mytmptext);

            //int j = problem.answerslist.IndexOf(inttemp);

            //problem.dividendlist.RemoveAt(j);
            //problem.answerslist.RemoveAt(j);

            
            //problem.dividendlist.RemoveAt(inttemp);
            //problem.answerslist.RemoveAt(inttemp);

            problem.dividendlist[inttemp] = 00;
            problem.answerslist[inttemp] = 00;

            displayToLog();
            calculation.updateProblem();

            Destroy(GetComponent<TMP_Text>());
        }

    }

    public void displayToLog()
    {
        string dstr = " ";
        foreach (int x in problem.dividendlist)
        {
            dstr += x + " ";
        }

        Debug.Log(dstr + "count: " + problem.dividendlist.Count);

        string astr = " ";
        foreach (int y in problem.answerslist)
        {
            astr += y + " ";
        }

        Debug.Log(astr + "count: " + problem.answerslist.Count);
    }
}
