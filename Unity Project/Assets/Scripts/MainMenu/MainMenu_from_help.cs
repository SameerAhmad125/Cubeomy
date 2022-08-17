using UnityEngine;

public class MainMenu_from_help : MonoBehaviour {
	
	public GameObject help;
	public GameObject menu;
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("b")){
			menu.SetActive(true);
			help.SetActive(false);
		}
	}
}
