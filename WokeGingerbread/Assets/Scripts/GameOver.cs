using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	public Score scoreManager;
	public Text winText;

    public void endGame() {
		if (scoreManager.getScore() < 10) {
			winText.text = "You Lose! \n Press 'R' to Restart!";

		}
	}

}
