﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {
    public int maxHits;
    LevelManager levelManager = new LevelManager();
    int timesHit;

	// Use this for initialization
	void Start () {

        timesHit = 0;

        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
        print(gameObject.name + " : " + timesHit);
        if (timesHit >= maxHits)
        {
            Destroy(gameObject);
        }
       
    }
    void TestWin()
    {
        levelManager.LoadNextScene();

    }
}
