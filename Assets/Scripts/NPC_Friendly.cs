using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC_Friendly : MonoBehaviour
{
	UIController uIController;

	public AudioSource audioSource;


	void Start()
	{
		uIController = GetComponent<UIController>();
	}
	public void Talk()
	{
		uIController.TalkFriendly();
		audioSource.Play();
	}
}
