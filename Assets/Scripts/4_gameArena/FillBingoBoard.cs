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

    private void Awake()
    {
        problem = GameObject.Find("Problem").GetComponent<Problem>();
    }

    private void OnEnable()
    {
        //problem = GameObject.Find("Problem").GetComponent<Problem>();
        myboard = GetComponentsInChildren<TMP_Text>();
        for (int i = 0; i < 25; i++)
        {
            myboard[i].text = problem.answerslist[i].ToString();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        /*myboard = GetComponentsInChildren<TMP_Text>();
        for (int i = 0; i < 25; i++)
        {
            myboard[i].text = problem.answerslist[i].ToString();
        }*/
    }
}
