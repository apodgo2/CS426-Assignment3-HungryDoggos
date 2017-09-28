using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

	public Score scoreManager;
	public int pointValue;

	private void OnCollisionEnter(Collision collision)
	{
		for (int i = 0; i < pointValue; i++) {
			scoreManager.AddPoint ();
		}
			
		Debug.Log ("Collision detected");
		Destroy (gameObject);

	}
		
}
