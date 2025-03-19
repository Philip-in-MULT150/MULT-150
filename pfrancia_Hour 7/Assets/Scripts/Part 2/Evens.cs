using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // get sum all numbers from 22 to 100
        int sum = 0;
        int count = 2;
        while (count <= 100)
        {
            Debug.Log("sum:" + sum + "count:" + count);
            sum = sum + count; // sum += count
            count++;
        }
        Debug.Log("final sum: " + sum);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
