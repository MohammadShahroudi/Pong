using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class DemoPaddle : MonoBehaviour
{
    public float leftPaddleSpeed = 1.0f;
    public float rightPaddleSpeed = 1.0f;
    public float forceStrength = 10.0f;
    public float maxZ = 5.0f;
    public GameObject leftPaddle;
    public GameObject rightPaddle;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        leftPaddle = GameObject.FindWithTag("leftPaddle");
        rightPaddle = GameObject.FindWithTag("rightPaddle");

        if (Keyboard.current.dKey.isPressed)
        {
            leftPaddle.transform.position += new Vector3(0f, 0f, leftPaddleSpeed) * Time.deltaTime;
        }

        if (Keyboard.current.aKey.isPressed)
        {
            leftPaddle.transform.position -= new Vector3(0.0f, 0.0f, leftPaddleSpeed) * Time.deltaTime;
        }

        if (Keyboard.current.lKey.isPressed)
        {
            rightPaddle.transform.position += new Vector3(0f, 0f, rightPaddleSpeed) * Time.deltaTime;
        }

        if (Keyboard.current.jKey.isPressed)
        {
            rightPaddle.transform.position -= new Vector3(0f, 0f, rightPaddleSpeed) * Time.deltaTime;
        }

        // float angle = 0.0f;

        // Vector3 up = Vector3.up;
        // Quaternion testRotation = Quaternion.Euler(45.0f, 0.0f, 0.0f);

        // Vector3 rotatedVector = testRotation * up;

        // Quaternion otherRotation = Quaternion.Euler(-45.0f, 0.0f, 0.0f);
        // Vector3 otherRotatedVector = otherRotation * up; 

        // Quaternion someOtherAngleRotation = Quaternion.Euler(angle, 0.0f, 0.0f);
        // Vector3 someOtherRotatedVector = someOtherAngleRotation * up;

        // Debug.DrawRay(transform.position, rotatedVector * 5.0f, Color.red);     
        // Debug.DrawRay(transform.position, otherRotatedVector * 5.0f, Color.blue);    
        // Debug.DrawRay(transform.position, someOtherRotatedVector * 5.0f, Color.green);      
    }

}
