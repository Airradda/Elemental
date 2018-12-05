using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour {
	public int HP = 100;
	private Slider HPBar;

	void Awake() {
		//HPBar = GetComponent<Slider>;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
		HPBar.value = HP;
	}
	void SetHP (int Health) {
		HP = Health;
	}
}
