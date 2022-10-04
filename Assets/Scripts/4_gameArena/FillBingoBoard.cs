using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class FillBingoBoard : MonoBehaviour
{
    Problem problem;
    TMP_Text[] myboard;

    Dividend dividend;
    Divisor divisor;
    Quotient quotient;

    void Awake()
    {
 
    }

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
        myboard = GetComponentsInChildren<TMP_Text>();
        for (int i = 0; i < 25; i++)
        {
            myboard[i].text = problem.answerslist[i].ToString();
        } 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
