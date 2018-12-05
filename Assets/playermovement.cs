using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour {

	public CharacterController2D controller;

	public float runspeed = 40f;
	
	float horizontalMove = 0f;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {

		horizontalMove = Input.GetAxisRaw("Horizontal") * runspeed;
		
	}

	void FixedUpdate () {
		controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
	}
}
