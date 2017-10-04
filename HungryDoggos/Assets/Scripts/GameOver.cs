using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	public Score scoreManager;
	public Text winText;
    public int winThreshold = 10;

    public void endGame() {
        if (scoreManager.getScore () < winThreshold) {
            winText.text = "You Lose! \n Press 'R' to Restart!";

        } else {
            //you win!
            SceneManager.LoadScene ("WinScene");
        }
	}

}
