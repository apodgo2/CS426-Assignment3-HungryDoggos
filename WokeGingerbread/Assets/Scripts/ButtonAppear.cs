using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAppear : MonoBehaviour {

	// Use this for initialization

	public GameObject button;
	//private bool active;
	public Text gameText;

	void Start(){
		button.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		if (gameText.text == "You Lose!\n Press 'R' to Restart!"){
			button.SetActive(true);
		}
		
	}
}
