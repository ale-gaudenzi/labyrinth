using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBoundary : MonoBehaviour
{
	private Vector3 spawn;

    void Start()
    {
        spawn = transform.position;
    }

    void Update()
    {
        if (transform.position[1] < -2){
			transform.position = spawn;	
            GetComponent<Rigidbody>().velocity = Vector3.zero;
 			GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
		}
    }
}
