using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

	public Score scoreManager;
	public Text winText;

	private void OnCollisionEnter(Collision collision)
	{
		Debug.Log ("Collision detected");

		if (scoreManager.getScore() < 10) {
			winText.text = "You Lose! \n Press 'R' to Restart!";

		}
	}

}
