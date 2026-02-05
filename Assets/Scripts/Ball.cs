using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Ball : MonoBehaviour
{
    public GameObject leftPaddle;
    public GameObject rightPaddle;
    public GameObject ball;
    // public bool collision = false;

    public float ballSpeed = 1.5f;
    public float increaseBallSpeed = 10.0f;
    private Rigidbody rb;

    // Adjust the force strength in the Inspector
    public float forceMagnitude = 20.0f;
    // Sets it at 45 degrees
    public float angle = 30.0f;

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
        // rb.velocity = Vector3.forward + Vector3.right * ballSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        
    }

    void OnCollisionStay(Collision collision)
    {
       
    }

    void OnDestroy()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        movementX = Mathf.Cos(43 * Mathf.Deg2Rad) * forceMagnitude;
        movementZ = Mathf.Sin(43 * Mathf.Deg2Rad) * forceMagnitude;

        Vector3 forceDirection = new Vector3(movementX, 0, movementZ);
        Vector3 eulerAngleVelocity = new Vector3(0, 100, 0);

        leftPaddle = GameObject.FindWithTag("leftPaddle");
        rightPaddle = GameObject.FindWithTag("rightPaddle");
        ball = GameObject.FindWithTag("Ball");

        if (collision.gameObject.CompareTag("rightPaddle"))
        {
            ballSpeed += increaseBallSpeed;
            // Debug.Log("Collision!");
            rb.linearVelocity = rb.linearVelocity.normalized * increaseBallSpeed;

            Quaternion deltaRotation = Quaternion.Euler(eulerAngleVelocity * Time.fixedDeltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);


            rb.AddForce(forceDirection, ForceMode.Impulse);
        }

        if (collision.gameObject.CompareTag("leftPaddle"))
        {
            ballSpeed += increaseBallSpeed;
            rb.linearVelocity = rb.linearVelocity.normalized * increaseBallSpeed;

            Quaternion deltaRotation = Quaternion.Euler(eulerAngleVelocity * Time.fixedDeltaTime);
            rb.MoveRotation(rb.rotation * deltaRotation);

            rb.AddForce(forceDirection, ForceMode.Impulse);
        }
        // Debug.Log("Ball Speed: " + ballSpeed);

        rb.linearVelocity = rb.linearVelocity.normalized * increaseBallSpeed;
    }
}
