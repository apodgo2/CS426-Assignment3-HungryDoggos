using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

	public Score scoreManager;
	//public int score;
	public Text winText;

	private void OnCollisionEnter(Collision collision)
	{
		//scoreManager.Equals ();

		Debug.Log ("Collision detected");
		//Destroy (gameObject);

		if (scoreManager.getScore() < 10) {
			winText.text = "You Lose! \n Press 'R' to Restart!";
			//scoreManager.setScore (-1);
		}
	}

}
