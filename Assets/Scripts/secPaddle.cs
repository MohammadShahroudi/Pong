using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class secPaddle : MonoBehaviour
{
    public float paddleSpeed = 1f;
    public float forceStrength = 10f;
    public float maxZ = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.lKey.isPressed)
        {
            // Vector3 force = new Vector3(0f, 0f, forceStrength);

            // Rigidbody rBody = GetComponent<Rigidbody>();
            // rBody.AddForce(force, ForceMode.Force);

            // BoxCollider boxCollider = GetComponent<BoxCollider>();
            // boxCollider.bounds.

            Vector3 newPosition = transform.position + new Vector3(0f, 0f, paddleSpeed) * Time.deltaTime;
            newPosition.z = Mathf.Clamp(newPosition.z, -10f, maxZ);

            transform.position = newPosition;

            //transform.position += new Vector3(0f, 0f, paddleSpeed) * Time.deltaTime;
        }

        if (Keyboard.current.jKey.isPressed)
        {
            // Vector3 force = new Vector3(0f, 0f, -forceStrength);

            // Rigidbody rBody = GetComponent<Rigidbody>();
            // rBody.AddForce(force, ForceMode.Force);

            transform.position -= new Vector3(0f, 0f, paddleSpeed) * Time.deltaTime;
        }
    }

    // Vector3 up = Vector3.up;
    // Quaternion testRotation = Quaternion.Euler(60f, 0f, 0f);

    // Vector3 rotatedVector = testRotation * up;

    // Quaternion otherRotation = Quaternion.Euler(-60f, 0f, 0f);
    // Vector3 otherRotatedVector = otherRotation * up;

    // Quaternion otherRotation = Quaternion.Euler(angle, 0f, 0f);
    // Vector3 otherRotatedVector = otherRotation * up;

    // Debug.DrawRay(transform.position, rotatedVector * 5f, Color.red);
    // Debug.DrawRay(transform.position, rotatedVector * 5f, Color.blue);

}

