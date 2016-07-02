using UnityEngine;
using System.Collections;
using Leap;
using System;
public class sixDoF : MonoBehaviour {

	private float moveSpeed = 0.0005f;
	private Vector tipVelocity ; 
	private Vector3 moveDirection;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){
		if (HandController.mode == 1) {
			tipVelocity = HandController.curr_righthand.Fingers[1].TipVelocity;
			moveDirection = new Vector3(tipVelocity.x,tipVelocity.y,-tipVelocity.z)*moveSpeed;
			transform.Translate(moveDirection);
		}

		if (HandController.mode == 2) {
			tipVelocity = HandController.curr_righthand.Fingers[1].TipVelocity;
			moveDirection = new Vector3(tipVelocity.y,-tipVelocity.z,tipVelocity.x)*moveSpeed*40;
			transform.Rotate(moveDirection);
		}

	}

}
