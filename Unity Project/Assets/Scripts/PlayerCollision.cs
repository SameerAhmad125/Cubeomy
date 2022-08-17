using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public movement playerMovement;
	
	void OnCollisionEnter(Collision other) {

		if(other.collider.tag == "obstacle"){
			playerMovement.enabled = false;
			FindObjectOfType<gameManager>().endgame();
		}
	}

}
