using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
	public Animator playerAnimator;


	PlayerMovement playerMovement;
	PlayerRenderer playerRenderer;
	PlayerAiInteractions playerAiInteractions;

	public GameObject ui_window;

	private Vector2 movementVector;


	private void Start()
	{
		playerMovement = GetComponent<PlayerMovement>();
		playerRenderer = GetComponent<PlayerRenderer>();
		playerAiInteractions = GetComponent<PlayerAiInteractions>();

	}
	private void Update()
	{
		movementVector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		movementVector.Normalize();
		if (Input.GetAxisRaw("Fire1") > 0)
		{
			playerAiInteractions.Interact(playerRenderer.IsSpriteFlipped);
		}
	}

	private void FixedUpdate()
	{
		MovePlayer(movementVector);
		if (movementVector.magnitude > 0)
		{
			ui_window.SetActive(false);
		}
		else
		{
			playerAnimator.SetBool("Walk", false);
		}
	}



	private void MovePlayer(Vector2 movementVector)
	{
		playerAnimator.SetBool("Walk", true);
		//rb2d.MovePosition(rb2d.position + movementVector * movementSpeed * Time.fixedDeltaTime);
		playerMovement.PlayerMove(movementVector);
		playerRenderer.RenderPlayer(movementVector);

	}

	public void ReceiveDamaged()
	{
		playerRenderer.FlashRed();
	}


}
