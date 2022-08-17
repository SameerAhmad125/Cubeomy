using UnityEngine;
using UnityEngine.SceneManagement;

public class NewLevel : MonoBehaviour {

	public void newLevel(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
}
