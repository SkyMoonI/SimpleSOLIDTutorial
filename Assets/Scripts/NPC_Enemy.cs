using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_Enemy : MonoBehaviour
{
	public AudioSource audioSource;
	UIController uIController;
	void Start()
	{
		uIController = GetComponent<UIController>();
	}
	public void GetHit()
	{
		uIController.TalkEnemy();
		audioSource.Play();
		FindObjectOfType<Player>().ReceiveDamaged();
	}

}
