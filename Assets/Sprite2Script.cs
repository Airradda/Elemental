﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprite2Script : MonoBehaviour {
    bool Right = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			if((Input.GetAxis("Horizontal2") > 0) && (Right == false))
			{
				Right = true;
				transform.Rotate(180, 0, 0);
			}
			else if((Input.GetAxis("Horizontal2") < 0) && (Right == true))
			{
				Right = false;
				transform.Rotate(180, 0, 0);
			}
	}
}
