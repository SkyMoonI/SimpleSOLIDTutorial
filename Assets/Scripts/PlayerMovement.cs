using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float movementSpeed;
	private Rigidbody2D rb2d;

	void Awake()
	{
		rb2d = GetComponent<Rigidbody2D>();

	}
	public void PlayerMove(Vector2 movementVector)
	{
		rb2d.velocity = movementVector * movementSpeed;
	}
}
