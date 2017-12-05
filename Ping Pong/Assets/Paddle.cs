using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float mousePosInUnits = (Input.mousePosition.y / Screen.width * 16) -6;

        Vector3 newPaddlePos = new Vector3(this.transform.position.x, mousePosInUnits, this.transform.position.z);
        newPaddlePos.y = Mathf.Clamp(mousePosInUnits, -4.36f, 4.36f);

        this.transform.position = newPaddlePos;
    }
}
