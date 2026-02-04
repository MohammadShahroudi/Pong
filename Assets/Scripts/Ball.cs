using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Ball : MonoBehaviour
{
    // private float time = 0.0f;
    // private bool isMoving = false;
    // private bool isJumpPressed = false;
    //Vector3 eulerAngleVelocity;

    public float ballSpeed = 5.0f;
    private Rigidbody rb;

    // Adjust the force strength in the Inspector
    public float forceMagnitude = 20.0f;
    // Sets it at 45 degrees
    public float angle = 45.0f;

    private float movementX;
    private float movementZ;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Calculate the direction vector
        movementX = Mathf.Cos(angle * Mathf.Deg2Rad) * forceMagnitude;
        movementZ = Mathf.Sin(angle * Mathf.Deg2Rad) * forceMagnitude;

        Vector3 forceDirection = new Vector3(movementX, 0, movementZ);
        Vector3 eulerAngleVelocity = new Vector3(0, 100, 0);

        // Adding an initial impulse
        rb.AddForce(forceDirection, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        //    Quaternion deltaRotation = Quaternion.Euler(eulerAngleVelocity * Time.fixedDeltaTime);
        //    rb.MoveRotation(rb.rotation * deltaRotation);
    }

    void OnCollisionStay(Collision collision)
    {
        // Debug.Log("Collision!");
        
    }

    private void OnCollisionEnter(Collision other)
    {
        Vector3 newVelocity = new Vector3(0.0f, 0.0f, 0.0f);
        Vector3 currentVelocity = rb.linearVelocity;

        newVelocity = currentVelocity + new Vector3(2.0f, 0.0f, 3.0f);
        Debug.Log("Velocity: " + currentVelocity);
        rb.linearVelocity = newVelocity;

        
    }
}
