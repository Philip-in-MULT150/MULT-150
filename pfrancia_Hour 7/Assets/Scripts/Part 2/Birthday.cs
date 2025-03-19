using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // count the 31 days of a week
        for (int day = 1; day <= 31; day++)
        {
            Debug.Log(day);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
