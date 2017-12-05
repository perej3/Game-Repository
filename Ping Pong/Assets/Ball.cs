using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
        this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
    }
	
	// Update is called once per frame
	void Update () {
        
    }
}
