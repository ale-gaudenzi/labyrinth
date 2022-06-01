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
			print("you win");
		}
		if(other.gameObject.tag=="enemy"){
			//GameClass.WeDie();
			transform.position = spawn;
		}
		
 	}
}
