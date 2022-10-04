using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem : MonoBehaviour
{
    public int divisor = 2;

    public List<int> dividendlist = new List<int>(25);
    public List<int> answerslist = new List<int>(25);

    private void Awake()
    {
        populate();
    }

    private void OnEnable()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
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
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void populate()
    {
        int div;

        int i = 0;
        while(i < 25)
        {
            div = UnityEngine.Random.Range(0, 10);
            if (div % divisor == 0)
            {
                dividendlist.Insert(i, div);
                answerslist.Insert(i, (div/divisor));
                i++;
            }
        }
    }
}
