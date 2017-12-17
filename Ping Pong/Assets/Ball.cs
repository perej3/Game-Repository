using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    Vector3 originalPos;
    
    // Use this for initialization
    void Start()
    { 
        originalPos = gameObject.transform.position;
        this.GetComponent<Rigidbody2D>().velocity = new Vector2((Random.Range(-11, 11)), 7f);
       

    }

    
   public static int score1;
   public static int score2;
   public static int score3;
   public static int score4;
   public static int score5;
   public static int score6;
   public static int totalScore1;
   public static int totalScore2;
    
    
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "goal_right")
        {
            score1++;
			totalScore1++;
            
            gameObject.transform.position = originalPos;
            
            

        }
        
       else if (coll.gameObject.name == "goal_left")
        {
            score2++;
            totalScore2++;
            gameObject.transform.position = originalPos;
            
            
        }
        
        if (coll.gameObject.name == "goal_right_2")
        {
            score3++;
			score3++;
			totalScore1++;
			totalScore1++;
            gameObject.transform.position = originalPos;
        }

        else if (coll.gameObject.name == "goal_left_2")
        {
            score4++;
			score4++;
			totalScore2++;
			totalScore2++;
            gameObject.transform.position = originalPos;
        }
		if (coll.gameObject.name == "goal_right_3")
		{
			score5++;
			score5++;
			totalScore1++;
			totalScore1++;
			
			gameObject.transform.position = originalPos;
		}
		else if(coll.gameObject.name == "goal_left_3")
		{
			score6++;
			score6++;
			totalScore2++;
			totalScore2++;
			
			gameObject.transform.position = originalPos;
		
		}
    }
   

    
// Update is called once per frame
void Update()
    {

        if (score1 == 10 || score2 == 10) 
        {
            
            SceneManager.LoadScene("Level 2");
            score1 = 0;
            score2 = 0;
        }

        if(score3 == 20|| score4 == 20)
        {
            
            SceneManager.LoadScene("Level 3");
            score3 = 0;
            score4 = 0;
        }
		if(score5 == 20 || score6 == 20)
		{
			
			SceneManager.LoadScene("End Screen");
			score5 = 0;
			score6 = 0;
		}
        

    }

}