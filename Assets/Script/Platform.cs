using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {
	public Transform[] patrolPoints;
	public float speed;
	private int currentPoint;
    public bool isTrigger;

	void Start () {
		try{
		transform.position = patrolPoints[0].position;
		}catch(System.IndexOutOfRangeException){
		}
		currentPoint = 0;

	}
	
	void Update () {
		try{
		if (transform.position.x == patrolPoints[currentPoint].position.x) {
            if(transform.position.z == patrolPoints[currentPoint].position.z) {
                currentPoint++;
            }
		}

		if (currentPoint >= patrolPoints.Length) {
			currentPoint = 0;
		}

		transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentPoint].position, Time.deltaTime * speed);
		}
		catch(System.IndexOutOfRangeException){
		}
	}

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("player")) return;
                if(isTrigger == true){

            other.transform.SetParent(transform, true);}
            //other.transform.parent = transform;

    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("player")) return;
        if(isTrigger == true){
            other.transform.SetParent(null);}
        //other.transform.parent = null;
    }
    
}
