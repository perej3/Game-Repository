using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDmanager : MonoBehaviour {

    public Text scoreUI;
    public Text scoreUIleft;
    public Text scoreUI_2;
    public Text scoreUIleft_2;
	public Text scoreUI_3;
    public Text scoreUIleft_3;
	public Text totalScore1UI;
	public Text totalScore2UI;
    
	// Use this for initialization
	void Start () {
        scoreUI.text = Ball.score1 + "";
        scoreUIleft.text = Ball.score2 + "";
        scoreUI_2.text = Ball.score3 + "";
        scoreUIleft_2.text = Ball.score4 + "";
		scoreUI_3.text = Ball.score5 + "";
        scoreUIleft_3.text = Ball.score6 + "";
		totalScore1UI = Ball.totalScore1 + "";
		totalScore2UI = Ball.totalScore2 + "";
		
    }
	
	// Update is called once per frame
	void Update () {
        scoreUI.text = Ball.score1 + "";
        scoreUIleft.text = Ball.score2 + "";
        scoreUI_2.text = Ball.score3 + "";
        scoreUIleft_2.text = Ball.score4 + "";
		scoreUI_3.text = Ball.score5 + "";
        scoreUIleft_3.text = Ball.score6 + "";
		
    }
}
