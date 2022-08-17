using UnityEngine;

public class EndGame : MonoBehaviour {

	public gameManager gameManager;

	void OnTriggerEnter(Collider other) {
		if(other.tag == "player"){
			gameManager.NextLevel();	
		}
	}

	
}
