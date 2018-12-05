using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
	private GameObject Player1;
	private GameObject Player2;
	float XPos;
	float YPos;
	float ZPos;

	// Use this for initialization
	void Start () {
		Player1 = GameObject.Find("Player_01");
		Player2 = GameObject.Find("Player_02");
        transform.Translate((Player1.transform.position + Player2.transform.position)/2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
