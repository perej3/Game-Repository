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

    
    int score1;
    int score2;
    
    
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

    }
      
    // Update is called once per frame
    void Update()
    {
        


    }
   
}