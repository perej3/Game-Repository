using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDmanager : MonoBehaviour {

    public Text scoreUI;
    public Text scoreUIleft;

    
	// Use this for initialization
	void Start () {
        scoreUI.text = Ball.score1 + "";
        scoreUIleft.text = Ball.score2 + "";
    }
	
	// Update is called once per frame
	void Update () {
        scoreUI.text = Ball.score1 + "";
        scoreUIleft.text = Ball.score2 + "";
    }
}
