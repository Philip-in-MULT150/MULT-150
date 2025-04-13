using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalConponents : MonoBehaviour
{
    Camera cameraComponent;

    // Start is called before the first frame update
    void Start()
    {
        cameraComponent = GetComponent<Camera>();
        cameraComponent.fieldOfView = 100f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
