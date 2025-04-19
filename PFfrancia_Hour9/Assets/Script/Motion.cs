using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motion : MonoBehaviour
{
    private Rigidbody rb;
    public float movementSpeed;
    private float dirX, dirZ;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        dirX = Input.GetAxis("Horizontal") * movementSpeed;
        dirZ = Input.GetAxis("Vertical") * movementSpeed;
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector3(rb.velocity.y, dirZ);
    }
}
