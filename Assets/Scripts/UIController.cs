using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
	public GameObject ui_window;
	public Text textField;
	public string enemyText = "I deal 10 physical damage    ( •̀ᴗ•́ )و ̑̑ ";
	public string friendlyText = "Hi there. Look out for that KOBOLD on the other side!";

	public void TalkEnemy()
	{
		ui_window.SetActive(true);
		textField.text = enemyText;
	}

	public void TalkFriendly()
	{
		ui_window.SetActive(true);
		textField.text = friendlyText;
	}
}
