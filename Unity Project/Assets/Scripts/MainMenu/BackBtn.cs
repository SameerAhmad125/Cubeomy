using UnityEngine;

public class BackBtn : MonoBehaviour {

		public GameObject menu_;
		public GameObject help_;

		public void Back(){
			menu_.SetActive(true);
			help_.SetActive(false);
		}
	
}
