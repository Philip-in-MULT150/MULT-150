using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    Light lightComponent;
    // Start is called before the first frame update
    void Start()
    {
        lightComponent = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) // called when an object enters a trigger
    {
        Debug.Log(other.gameObject.name + " entered object trigger ");
        lightComponent.enabled = !lightComponent.enabled;
    }

    private void OnTriggerStay(Collider other) // called while an object is in a trigger
    {
        Debug.Log(other.gameObject.name + " is in object trigger ");
    }

    private void OnTriggerExit(Collider other) // called when an object exits a trigger
    {
        Debug.Log(other.gameObject.name + " exited object trigger ");
    }
}
