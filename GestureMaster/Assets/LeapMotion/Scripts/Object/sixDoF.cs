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
			moveDirection = tipVelocity.ToUnity()*moveSpeed;
//			moveDirection.x = tipVelocity.x*moveSpeed;
//			moveDirection.y = tipVelocity.y*moveSpeed;
//			moveDirection.z = -1*tipVelocity.z*moveSpeed;
			transform.Translate(moveDirection,Space.Self);
			Debug.Log("The tip velocity is :"+tipVelocity.x+" "+tipVelocity.y+" "+tipVelocity.z);
			Debug.Log("The move Direction is :"+moveDirection.x+" "+ moveDirection.y+" "+moveDirection.z);
		}

		if (HandController.mode == 2) {
			tipVelocity = HandController.curr_righthand.Fingers[1].TipVelocity;
			moveDirection.x = tipVelocity.y*moveSpeed*30;
			moveDirection.y = -1*tipVelocity.z*moveSpeed*30;
			moveDirection.z = tipVelocity.x*moveSpeed*30;
			transform.Rotate(moveDirection,Space.Self);
		}

	}

}
