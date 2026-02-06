using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using TMPro;

public class gameManager : MonoBehaviour
{
    public GameObject leftGoal;
    public GameObject rightGoal;
    private Rigidbody rb;

    public int leftPaddleScore = 0;
    public int rightPaddleScore = 0;

    public int count;
    public TextMeshProUGUI countText;

    // public GameObject ballPrefab;
    // public Vector3 spawnPos;

    // Round starts spawn ball
    // if player was scored on then destroy ball
    // increment score to player
    // spawn new ball towards player who was just scored on

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        count = 0;

        SetCountText();
    }

    void SetCountText()
    {
        countText.text = "Score: " + leftPaddleScore.ToString() + " - " + rightPaddleScore.ToString();

        if (leftPaddleScore >= 1)
        {
            Debug.Log("Game Over! Left Paddle Wins!");
            // winTextObject.SetActive(true);
        }
        if (rightPaddleScore >= 1)
        {
            Debug.Log("Game Over! Right Paddle Wins!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        // this refers to itself 
        if (this.gameObject.CompareTag("rightGoal"))
        {
            Debug.Log("Left Paddle Scores!");
            leftPaddleScore = leftPaddleScore + 1;
        }
        // this refers to itself
        if (this.gameObject.CompareTag("leftGoal"))
        {
            Debug.Log("Right Paddle Scores!");
            rightPaddleScore = rightPaddleScore + 1;
        }
        // Respawn();
        // Instantiate(ballPrefab, spawnPos, Quaternion.identity);
        SetCountText();
    }
}
