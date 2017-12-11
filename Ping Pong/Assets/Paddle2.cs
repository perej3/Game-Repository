using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            
            Vector3 position = this.transform.position;
           position.y =  position.y + 0.5f;
            position.y = Mathf.Clamp(position.y, -4.36f, 4.36f);
            
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            
            Vector3 position = this.transform.position;
            position.y = position.y - 0.5f;
            position.y = Mathf.Clamp(position.y, -4.36f, 4.36f);
            
            this.transform.position = position;
            
        }
    }
}