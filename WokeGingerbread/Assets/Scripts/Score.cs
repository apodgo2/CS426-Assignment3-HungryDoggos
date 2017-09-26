using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Text scoreText;
	public Text winText;
	public int maxScore = 10;

	int score;

	// Use this for initialization
	void Start () 
	{
		score = 0;
		scoreText.text = "Score: " + score;
		winText.text = "";
	}
	
	// Update is called once per frame
	public void AddPoint ()
	{
		score++;

		if (score < maxScore){
			scoreText.text = "Score: " + score;
		}else { 
			scoreText.text = "Score: " + score;
			winText.text = "You won! \n Press 'R' to Restart!";
		}
	}

	public void setScore(int num)
	{
		score = num;
	}

	public int getScore(){
		return score;
	}
}
