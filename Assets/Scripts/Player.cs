using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

	public GameObject ui_window;


	PlayerMovement playerMovement;
	PlayerRenderer playerRenderer;
	PlayerAiInteractions playerAiInteractions;
	PlayerInput playerInput;
	PlayerAnimations playerAnimations;


	private void Start()
	{
		playerMovement = GetComponent<PlayerMovement>();
		playerRenderer = GetComponent<PlayerRenderer>();
		playerAiInteractions = GetComponent<PlayerAiInteractions>();
		playerInput = GetComponent<PlayerInput>();
		playerInput.OnInteractEvent += () => playerAiInteractions.Interact(playerRenderer.IsSpriteFlipped);
		playerAnimations = GetComponent<PlayerAnimations>();
	}


	private void FixedUpdate()
	{
		playerMovement.PlayerMove(playerInput.MovementInputVector);
		playerRenderer.RenderPlayer(playerInput.MovementInputVector);
		playerAnimations.SetupAnimations(playerInput.MovementInputVector);
		if (playerInput.MovementInputVector.magnitude > 0)
		{
			ui_window.SetActive(false);
		}
	}

	public void ReceiveDamaged()
	{
		playerRenderer.FlashRed();
	}


}
