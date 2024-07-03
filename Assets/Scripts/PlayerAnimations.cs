using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
	public Animator playerAnimator;

	public void SetupAnimations(Vector2 movementVector)
	{
		if (movementVector.magnitude > 0f)
			playerAnimator.SetBool("Walk", true);
		else
			playerAnimator.SetBool("Walk", false);
	}
}
