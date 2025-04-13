using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("The A key Is Presed");
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("The Z key Is Presed");
        }
    }
}
