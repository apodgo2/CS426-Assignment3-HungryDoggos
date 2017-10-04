using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doggo : MonoBehaviour {

    float lastBark = 0;
    public int penaltySecs = 10;

    public void bark() { // a dog can bark once a second
        if (Time.time >= lastBark+1) {
            //play sound
            AudioSource dogaudio = this.gameObject.GetComponent<AudioSource> ();
            if (dogaudio != null) {
                float pitchbend = ((float)Random.Range (-5, 5) / 15f);
                dogaudio.pitch = (1 + pitchbend);
                dogaudio.PlayOneShot (dogaudio.clip);
            }
			if (DetectBehaviour.withinRange || DetectBehaviour.withinRangeGP2) {
                //we're within range, ask Gingerperson to give food.

				DetectBehaviour.getClosest ().GetComponent<Gingerperson> ().giveFood ();
				Timer.subtractTime (penaltySecs);

				/*
                if (!DetectBehaviour.getClosest ().GetComponent<Gingerperson> ().giveFood ()) {
                    //we didn't get food *sadtrombone.wav*
                    //so now we subtract some points from our poor doggo's score.
                    Timer.subtractTime (penaltySecs);//configurable penalty...
                }
				Timer.subtractTime (penaltySecs);
				*/
            }
            //check detectbehaviour for distance
            //tell gingerbreadman to give out food, if he can
            //if he can't, subtract points, otherwise, we're done.
            lastBark = Time.time;
        }
    }


}
