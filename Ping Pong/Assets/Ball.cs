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
    
    
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "goal_right")
        {
            score1++;
            
            gameObject.transform.position = originalPos;
            
            

        }
        
       else if (coll.gameObject.name == "goal_left")
        {
            score2++;
            
            gameObject.transform.position = originalPos;
            
            
        }
        
        if (coll.gameObject.name == "goal_right_2")
        {
            score3++;

            gameObject.transform.position = originalPos;
        }

        else if (coll.gameObject.name == "goal_left_2")
        {
            score4++;

            gameObject.transform.position = originalPos;
        }
		if (coll.gameObject.name == "game_right_3")
		{
			score5++;
			
			gameObject.transform.position = originalPos;
		}
		else if(coll.gameObject.name == "goal_left_3")
		{
			score6++;
			
			gameObject.transform.position = originalPos;
		
		}
    }
   

    
// Update is called once per frame
void Update()
    {

        if (score1 == 2 || score2 == 2) 
        {
            
            SceneManager.LoadScene("Level 2");
            score1 = 0;
            score2 = 0;
        }

        if(score3 == 2 || score4 == 2)
        {
            
            SceneManager.LoadScene("Level 3");
            score3 = 0;
            score4 = 0;
        }
		if(score5 == 2 || score6 == 2)
		{
			SceneManager.LoadScene("Main Menu");
		}
        

    }

}