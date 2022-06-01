using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
	public float moveSpeed;

	private float maxSpeed = 20f;
	private Vector3 input;
	private Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
		rb.velocity = Vector3.zero;
	}

	// Update is called once per frame
	void Update()
	{
		input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
		if (rb.velocity.magnitude < maxSpeed)
		{
			rb.AddForce(input * moveSpeed);
		}
		
		
	}
}
