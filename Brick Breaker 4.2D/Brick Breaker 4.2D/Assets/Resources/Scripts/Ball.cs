﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
   Paddle paddle;
    Vector3 paddleBallPosDiff;
    bool gameStarted = false;
	// Use this for initialization
	void Start () {

        paddle = GameObject.FindObjectOfType<Paddle>();
        paddleBallPosDiff = this.transform.position - paddle.transform.position; 		
	}
	
	// Update is called once per frame
	void Update () {
        if (!gameStarted)
        {
            this.transform.position = paddle.transform.position + paddleBallPosDiff;
        }
        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            gameStarted = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (gameStarted)
        {
            GetComponent<AudioSource>().Play();
        }
        
    }
}
