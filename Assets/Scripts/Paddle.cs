using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class DemoPaddle : MonoBehaviour
{
    public float paddleSpeed = 1.0f;
    public float forceStrength = 10.0f;
    public float maxZ = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.dKey.isPressed)
        {
            // Vector3 force = new Vector3(0f, 0f, forceStrength);

            // Rigidbody rBody = GetComponent<Rigidbody>();
            // rBody.AddForce(force, ForceMode.Force);

            // BoxCollider boxCollider = GetComponent<BoxCollider>();
            // boxCollider.bounds.

            Vector3 newPosition = transform.position + new Vector3(0.0f, 0.0f, paddleSpeed) * Time.deltaTime;
            newPosition.z = Mathf.Clamp(newPosition.z, -10.0f, maxZ);

            transform.position = newPosition;

            //transform.position += new Vector3(0f, 0f, paddleSpeed) * Time.deltaTime;
        }

        if (Keyboard.current.aKey.isPressed)
        {
            // Vector3 force = new Vector3(0f, 0f, -forceStrength);

            // Rigidbody rBody = GetComponent<Rigidbody>();
            // rBody.AddForce(force, ForceMode.Force);

            transform.position -= new Vector3(0.0f, 0.0f, paddleSpeed) * Time.deltaTime;
        }

        float angle = 0.0f;

        Vector3 up = Vector3.up;
        Quaternion testRotation = Quaternion.Euler(45.0f, 0.0f, 0.0f);

        Vector3 rotatedVector = testRotation * up;

        Quaternion otherRotation = Quaternion.Euler(-45.0f, 0.0f, 0.0f);
        Vector3 otherRotatedVector = otherRotation * up; 

        Quaternion someOtherAngleRotation = Quaternion.Euler(angle, 0.0f, 0.0f);
        Vector3 someOtherRotatedVector = someOtherAngleRotation * up;

        Debug.DrawRay(transform.position, rotatedVector * 5.0f, Color.red);     
        Debug.DrawRay(transform.position, otherRotatedVector * 5.0f, Color.blue);    
        Debug.DrawRay(transform.position, someOtherRotatedVector * 5.0f, Color.green);      
    }

}
