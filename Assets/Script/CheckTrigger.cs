using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTrigger : MonoBehaviour
{
	private Vector3 spawn;
	private bool onPlatform;

    void Start() {
        spawn = transform.position;
		onPlatform = false;
    }
	
	void OnTriggerEnter(Collider other) {
    	if(other.gameObject.tag=="goal"){
			GameClass.CompleteLevel();
		}

		if(other.gameObject.tag=="enemy" || other.gameObject.tag=="lava" || other.gameObject.tag=="obstacle"){		
			if(!onPlatform) {
				transform.position = spawn;
				GameClass.WeDied();
				GetComponent<Rigidbody>().velocity = Vector3.zero;
 				GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
			}
		}

		if(other.gameObject.tag == "key") {
			OpenGate.KeyTaken();
		}
 	}

	void OnTriggerStay(Collider other) {
		if(other.gameObject.tag=="platform"){
			onPlatform = true;
		}
	}

	void OnTriggerExit(Collider other) {
		if(other.gameObject.tag=="platform"){
			onPlatform = false;
		}
	}
}
