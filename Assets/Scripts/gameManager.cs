using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class gameManager : MonoBehaviour
{
    public GameObject leftGoal;
    public GameObject rightGoal;
    private Rigidbody rb;

    // Round starts spawn ball
    // if player was scored on then destroy ball
    // increment score to player
    // spawn new ball towards player who was just scored on

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

    }
}
