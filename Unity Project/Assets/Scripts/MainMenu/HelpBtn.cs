using UnityEngine;

public class HelpBtn : MonoBehaviour {

	public GameObject menu_;
	public GameObject help_;

	public void Help(){
		menu_.SetActive(false);
		help_.SetActive(true);
	}
}
