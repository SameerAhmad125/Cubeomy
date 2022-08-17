﻿using UnityEngine;

public class movement : MonoBehaviour {
	

	public Rigidbody rb;
	public float forwardForce = 1000f;
	public float sideways_force = 500f;

	

	// Update is called once per frame
	void Update () {
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);

		if( Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d")){
			rb.AddForce(sideways_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if( Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a")){
			rb.AddForce(-sideways_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if(rb.position.y < 1f){
			FindObjectOfType<gameManager>().endgame();
		}

	}
}
