using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // count the 7 days of a week
        for (int day = 1; day <= 7; day++)
        {
            Debug.Log(day);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
