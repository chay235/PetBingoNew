using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Calculation : MonoBehaviour
{
    Problem problem;

    Dividend dividend;
    Divisor divisor;
    Quotient quotient;

    public int i;

    public int currentquotient;

    private void OnEnable()
    {
        problem = GameObject.Find("Problem").GetComponent<Problem>();
        dividend = GameObject.Find("dividend").GetComponent<Dividend>();
        divisor = GameObject.Find("divisor").GetComponent<Divisor>();
        quotient = GameObject.Find("quotient").GetComponent<Quotient>();
    }

    // Start is called before the first frame update
    void Start()
    {
        updateProblem();
    }

   public void updateProblem()
    {
        i = UnityEngine.Random.Range(0, problem.dividendlist.Count - 1);

        if (problem.dividendlist.Count > 0)
        {
            if (problem.dividendlist[i] != 00)
            {
                dividend.GetComponent<TMP_Text>().text = problem.dividendlist[i].ToString();
                divisor.GetComponent<TMP_Text>().text = problem.divisor.ToString();
                currentquotient = problem.dividendlist[i] / problem.divisor;
                quotient.GetComponent<TMP_Text>().text = currentquotient.ToString();
            }
            else
            {
                updateProblem();
            }
     
        }
    }
}
