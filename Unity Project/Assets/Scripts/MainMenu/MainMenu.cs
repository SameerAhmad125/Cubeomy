using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public GameObject Help;
	public GameObject Menu;
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("p")){
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}

		if(Input.GetKey("h")){
			Menu.SetActive(false);
			Help.SetActive(true);
		}

		if(Input.GetKey("q")){
			Application.Quit();
		}

	}
}
