using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

	public Score scoreManager;
	public int pointValue;
    public AudioClip targetHit;
    public AudioSource audioSource;

	private void OnCollisionEnter(Collision collision)
	{

        //Debug.Log (collision.gameObject.ToString ()); prints name of collided object for debug
        if (collision.gameObject.name.Equals ("dog")) {
            //check to see if we're colliding with the dog, if so, calculate points
            //this fixes the "target collides with ground" accidental point trigger
            for (int i = 0; i < pointValue; i++) {
                scoreManager.AddPoint ();
            }

            audioSource.PlayOneShot (targetHit);
            Debug.Log ("Dog Collision detected");
            Destroy (gameObject);
        }
	}
		
}
