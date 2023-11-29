using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour {
	Vector2 moveAmount;
	public float speed = 0.1f;
	bool isMoving;

	private void Awake() {
	
	}

	public void OnMove(InputAction.CallbackContext context) {
		moveAmount = context.ReadValue<Vector2>();
	}

	void Update() {
		move();
	}

	void move() {
		transform.position += new Vector3(moveAmount.x, moveAmount.y) * speed;
	}
	// moveDirection = orientation.forward * CurrentMovementInput.y + orientation.right * CurrentMovementInput.x;
	// moveDirection.Normalize();
}
