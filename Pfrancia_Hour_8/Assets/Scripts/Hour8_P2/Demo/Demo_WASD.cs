using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo_WASD : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalValue = Input.GetAxis("Horizontal");
        float verticalValue = Input.GetAxis("Vertical");

        if (horizontalValue != 0)
        {
            Debug.Log("horizontal movement: " + horizontalValue);
        }

        if (verticalValue != 0)
        {
            Debug.Log("vertical movement: " + verticalValue);
        }
    }
}
