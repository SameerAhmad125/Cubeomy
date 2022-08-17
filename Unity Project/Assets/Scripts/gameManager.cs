using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour {

	bool gameHasEnded = false;

	public float restartDelay = 2f;

	public GameObject nextLevelUI;

	public GameObject GameOver;

	public void NextLevel(){
		nextLevelUI.SetActive(true);
	}
	public void endgame(){
		if(gameHasEnded == false){
			gameHasEnded = true;
			GameOver.SetActive(true);
			Invoke("Restart", restartDelay);
		}
	}

	void Restart(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
