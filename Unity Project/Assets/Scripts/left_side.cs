using UnityEngine;

public class left_side : MonoBehaviour {

	public BoxCollider box;
    

    void OnTriggerEnter(Collider other) {
    var hello = box.isTrigger;

        if(other.tag == "player"){
            box.isTrigger = !hello;
        }
        else if(other.tag != "player"){
            box.isTrigger = hello;
        }
    }
}
//if player.x > floor_width :player.x == floor_width