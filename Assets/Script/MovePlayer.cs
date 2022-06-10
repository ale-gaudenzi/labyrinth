using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
	public float moveSpeed;
	public float jumpForce;
	
	private float maxSpeed = 20f;
	private Vector3 input;
	private Rigidbody rb;

	void Start() {
		rb = GetComponent<Rigidbody>();
		rb.velocity = Vector3.zero;
	}

	// Update is called once per frame
	void Update() {
		if(!OverlayManager.isPaused && !OverlayManager.isOverlay) {
			input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
			
			if (rb.velocity.magnitude < maxSpeed) {
				if(rb.position.y < 0.02f) {
					rb.AddForce(input * moveSpeed * Time.deltaTime * 200);
				} else{
					rb.AddForce(input * moveSpeed * Time.deltaTime * 20);

				}
			}
		
			if (Input.GetKeyDown(KeyCode.Space) && rb.position.y < 0.02f) {
        		rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    		}

		}
	}
}
