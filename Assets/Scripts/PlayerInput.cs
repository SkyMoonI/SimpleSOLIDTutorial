using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
	public Vector2 MovementInputVector { get; private set; }
	public event Action OnInteractEvent;
	// Update is called once per frame
	void Update()
	{
		GetMovementInput();
		GetInteractInput();
	}
	public void GetMovementInput()
	{
		MovementInputVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		MovementInputVector.Normalize();
	}
	public void GetInteractInput()
	{
		if (Input.GetAxisRaw("Fire1") > 0)
		{
			OnInteractEvent?.Invoke();
		}
	}
}
