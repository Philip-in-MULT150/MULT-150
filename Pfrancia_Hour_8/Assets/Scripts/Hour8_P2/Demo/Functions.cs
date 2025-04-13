using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string sentence = "W in Chat";
        //LogSomething(sentence);

        string sentence2 = "L in Chat";
        //LogSomething(sentence2);

        LogSomething("Im Hard At X");

        LogSomething("W Coding!", 100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LogSomething(string something, int numbloops)
    {
        for (int i = 1; i <= numbloops; i++)
        {
            Debug.Log(something);
        }
    }

    void LogSomething(string something)
    {
        for(int i = 1; i<= 3; i++)
        {
            Debug.Log(something);
        }
    }
}
