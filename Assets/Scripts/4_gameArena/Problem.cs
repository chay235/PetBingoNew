using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Problem : MonoBehaviour
{
    public int divisor = 2;

    public List<int> dividendlist = new List<int>(25);
    public List<int> answerslist = new List<int>(25);

    public List<int> bingo_h1 = new List<int>(5);
    public List<int> bingo_h2 = new List<int>(5);
    public List<int> bingo_h3 = new List<int>(5);
    public List<int> bingo_h4 = new List<int>(5);   
    public List<int> bingo_h5 = new List<int>(5);

    public List<int> bingo_v1 = new List<int>(5);
    public List<int> bingo_v2 = new List<int>(5);
    public List<int> bingo_v3 = new List<int>(5);
    public List<int> bingo_v4 = new List<int>(5);
    public List<int> bingo_v5 = new List<int>(5);

    public List<int> bingo_d1 = new List<int>(5);
    public List<int> bingo_d2 = new List<int>(5);


    private void Awake()
    {
        populate();
    }

    IEnumerator logBingo()
    {
        yield return new WaitForSeconds(.3f);
        printBingo();
    }

    // Start is called before the first frame update
    void Start()
    {
        populateCorrectBingo();

        string dstr = " ";
        foreach (int x in dividendlist)
        {
            dstr += x + " "; 
        }
        Debug.Log(dstr);

        string astr = " ";
        foreach (int y in answerslist)
        {
            astr += y + " "; 
        }
        Debug.Log(astr);

        StartCoroutine(logBingo());
    }

    void populateCorrectBingo()
    {
        for (int i = 0; i < 5; i++)
        {
            bingo_h1.Insert(i, answerslist[i]);
            bingo_h2.Insert(i, answerslist[i + 5]);
            bingo_h3.Insert(i, answerslist[i + 10]);
            bingo_h4.Insert(i, answerslist[i + 15]);
            bingo_h5.Insert(i, answerslist[i + 20]);
        }

            bingo_v1.Add(answerslist[0]);
            bingo_v2.Add(answerslist[1]);
            bingo_v3.Add(answerslist[2]);
            bingo_v4.Add(answerslist[3]);
            bingo_v5.Add(answerslist[4]);

            bingo_v1.Add(answerslist[5]);
            bingo_v2.Add(answerslist[6]);
            bingo_v3.Add(answerslist[7]);
            bingo_v4.Add(answerslist[8]);
            bingo_v5.Add(answerslist[9]);

            bingo_v1.Add(answerslist[10]);
            bingo_v2.Add(answerslist[11]);
            bingo_v3.Add(answerslist[12]);
            bingo_v4.Add(answerslist[13]);
            bingo_v5.Add(answerslist[14]);

            bingo_v1.Add(answerslist[15]);
            bingo_v2.Add(answerslist[16]);
            bingo_v3.Add(answerslist[17]);
            bingo_v4.Add(answerslist[18]);
            bingo_v5.Add(answerslist[19]);

            bingo_v1.Add(answerslist[20]);
            bingo_v2.Add(answerslist[21]);
            bingo_v3.Add(answerslist[22]);
            bingo_v4.Add(answerslist[23]);
            bingo_v5.Add(answerslist[24]);

            bingo_d1.Add(answerslist[0]);
            bingo_d1.Add(answerslist[6]);
            bingo_d1.Add(answerslist[12]);
            bingo_d1.Add(answerslist[18]);
            bingo_d1.Add(answerslist[24]);

            bingo_d2.Add(answerslist[4]);
            bingo_d2.Add(answerslist[8]);
            bingo_d2.Add(answerslist[12]);
            bingo_d2.Add(answerslist[16]);
            bingo_d2.Add(answerslist[20]);

        /*
        for (int i=0; i<5; i++)
        {
            for (int j=0; j<25; j+=6)
            {
                bingo_d1.Insert(i, answerslist[j]);
                break;
            }
        }

        for (int i=0; i<5; i++)
        {
            for(int j=4; j<25; j+=4)
            {
                bingo_d2.Insert(i, answerslist[j]);
                break;
            }
        }
        */



        /*
        bingo_v1.Insert(0, answerslist[0]);
        bingo_v2.Insert(0, answerslist[1]);
        bingo_v3.Insert(0, answerslist[2]);
        bingo_v4.Insert(0, answerslist[3]);
        bingo_v5.Insert(0, answerslist[4]);

        bingo_v1.Insert(1, answerslist[5]);
        bingo_v2.Insert(1, answerslist[6]);
        bingo_v3.Insert(1, answerslist[7]);
        bingo_v4.Insert(1, answerslist[8]);
        bingo_v5.Insert(1, answerslist[9]);

        bingo_v1.Insert(2, answerslist[10]);
        bingo_v2.Insert(2, answerslist[11]);
        bingo_v3.Insert(2, answerslist[12]);
        bingo_v4.Insert(2, answerslist[13]);
        bingo_v5.Insert(2, answerslist[14]);

        bingo_v1.Insert(3, answerslist[15]);
        bingo_v2.Insert(3, answerslist[16]);
        bingo_v3.Insert(3, answerslist[17]);
        bingo_v4.Insert(3, answerslist[18]);
        bingo_v5.Insert(3, answerslist[19]);

        bingo_v1.Insert(4, answerslist[20]);
        bingo_v2.Insert(4, answerslist[21]);
        bingo_v3.Insert(4, answerslist[22]);
        bingo_v4.Insert(4, answerslist[23]);
        bingo_v5.Insert(4, answerslist[24]);
        */

        /*for (int i = 1; i < 5; i++)
        {
            int j = 0;
            int k = 1;
            int l = 3;
            int m = 4;
            int n = 5;

            bingo_v1.Insert(i, answerslist[j+=5]);
            bingo_v2.Insert(i, answerslist[k+=5]);
            bingo_v3.Insert(i, answerslist[l+=5]);
            bingo_v3.Insert(i, answerslist[m+=5]);
            bingo_v4.Insert(i, answerslist[n+=5]);

            j += 5;
            k += 5;
            l += 5;
            m += 5;
            n += 5;
        }*/
    }

    void printBingo()
    {
        string h1 = " ";
        foreach (int y in bingo_h1)
        {
            h1 += y + " ";
        }
        
        string h2 = " ";
        foreach (int y in bingo_h2)
        {
            h2 += y + " ";
        }

        string v1 = " ";
        foreach (int y in bingo_v1)
        {
            v1 += y + " ";
        }
  
        string v2 = " ";
        foreach (int y in bingo_v2)
        {
            v2 += y + " ";
        }

        string v3 = " ";
        foreach(int y in bingo_v3)
        {
            v3 += y + " ";
        }

        string v4 = " ";
        foreach (int y in bingo_v4)
        {
            v4 += y + " ";
        }

        string v5 = " ";
        foreach (int y in bingo_v5)
        {
            v5 += y + " ";
        }

        string d1 = " ";
        foreach (int y in bingo_d1)
        {
            d1 += y + " ";
        }

        string d2 = " ";
        foreach (int y in bingo_d2)
        {
            d2 += y + " ";
        }

        Debug.Log(h1);
        Debug.Log(h2);
        Debug.Log(v1);
        Debug.Log(v2);
        Debug.Log(v3);
        Debug.Log(v4);
        Debug.Log(v5);     
        Debug.Log(d1);
        Debug.Log(d2);
    }

    void populate()
    {
        int dividend;

        int i = 0;
        while(i < 25)
        {
            dividend = UnityEngine.Random.Range(0, 10);
            if (dividend % divisor == 0)
            {
                dividendlist.Insert(i, dividend);
                answerslist.Insert(i, (dividend/divisor));
                i++;
            }
        }
    }
}
