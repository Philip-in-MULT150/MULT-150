using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightToggle : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.L))
            this.GetComponent<Light>().enabled = true;
        if (Input.GetKey(KeyCode.A))
            this.GetComponent<Light>().enabled = false;
    }
}
