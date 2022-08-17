﻿using UnityEngine;

public class Player_Follower : MonoBehaviour {
	
	public Transform player;
	public Vector3 cameraPosition;

	// Update is called once per frame
	void Update () {
		transform.position = player.position + cameraPosition;
	}
}
