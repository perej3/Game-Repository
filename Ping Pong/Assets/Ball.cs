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
    
    
    
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "goal_right")
        {
            score1++;
            gameObject.transform.position = originalPos;
            new WaitForSeconds(1);
            

        }
        
       else if (coll.gameObject.name == "goal_left")
        {
            score2++;
            gameObject.transform.position = originalPos;
            new WaitForSeconds(1);
            
        }
      

    }
   
    
    // Update is called once per frame
    void Update()
    {
        
        

        if (score1 == 3 || score2 == 3)
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
   
}