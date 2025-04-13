using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASD : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpHeight = 2f;
    public float gravity = -9.81f;

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (rb == null)
        {
            Debug.LogError("Rigidbody not found on GameObject.  Ensure it has one.");
        }
    }

    void Update()
    {
        // Movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(horizontalInput, 0, verticalInput).normalized;
        if (moveDirection.magnitude >= 0.1f)
        {
            rb.AddForce(moveDirection * moveSpeed, ForceMode.Force);
        }

        // Jumping
        if (Input.GetKeyDown("space") && isGrounded)
        {
            rb.AddForce(Vector3.up * Mathf.Sqrt(jumpHeight * -2f * gravity), ForceMode.VelocityChange);
            isGrounded = false; // Ensure grounded state is reset after jumping
        }

        // Gravity
        if (!isGrounded && rb.velocity.y < 0)
        {
            rb.AddForce(gravity * rb.mass * Vector3.down);
        }

        // Ground Check (simplified)
        RaycastHit hit;
        if (Physics.Raycast(transform.position + Vector3.up * 0.2f, Vector3.down, out hit, 0.3f))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }
}
