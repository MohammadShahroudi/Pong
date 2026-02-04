using System;
using UnityEngine;
using UnityEngine.InputSystem;


public class Score : MonoBehaviour
{
    public int leftPaddleScore = 0;
    public int rightPaddleScore = 0;

    public int count = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Current Score: ");
        Debug.Log("Left Paddle: " + leftPaddleScore);
        Debug.Log("Right Paddle: " + rightPaddleScore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
