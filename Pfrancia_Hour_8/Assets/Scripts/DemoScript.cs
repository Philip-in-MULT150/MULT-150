using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontleValue = Input.GetAxis("Horizontal");
        float verticalValue = Input.GetAxis("Vertical");

        if (horizontleValue != 0)
        {
            Debug.Log("Horizontal movement: " + horizontleValue);
        }

        if (verticalValue != 0)
        {
            Debug.Log("vertical movement: " + verticalValue);
        }
    }
}
