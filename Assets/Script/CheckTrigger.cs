using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTrigger : MonoBehaviour
{
	private Vector3 spawn;

    void Start()
    {
        spawn = transform.position;
    }

    void Update()
    {
		
		
    }
	
	void OnTriggerEnter(Collider other)
 	{
    	if(other.gameObject.tag=="goal"){
			GameClass.CompleteLevel();
		}
		if(other.gameObject.tag=="enemy" || other.gameObject.tag=="lava"){
			GameClass.WeDied();
			transform.position = spawn;

			GetComponent<Rigidbody>().velocity = Vector3.zero;
 			GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
		}
		
 	}
}
