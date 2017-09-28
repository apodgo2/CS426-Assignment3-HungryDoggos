using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gingerperson : MonoBehaviour {

    public bool hasFood = true;
    public GameObject foodToGive;
    public AudioClip denySound;
    public AudioClip giveSound;

    int trombones = 1;//how many trombones can be played

    public bool giveFood() {
        if (hasFood) {
            StartCoroutine(ExecuteAfterTime(1, true));
            hasFood = false;
            return true;
        } else {
            //no food to give
            StartCoroutine (ExecuteAfterTime (1, false));
            return false;
        }
    }

    IEnumerator ExecuteAfterTime(float time, bool doGive)
    {
        yield return new WaitForSeconds(time);
        AudioSource audiosource = gameObject.GetComponent<AudioSource> ();

        if (doGive) {
            //play the "food given out" sound
            if (audiosource != null) {
                audiosource.PlayOneShot (giveSound);
            }

            //create the food
            Vector3 foodLoc = new Vector3 (transform.position.x + 5, transform.position.y - 2.5f, transform.position.z + 5);
            Instantiate (foodToGive, foodLoc, transform.rotation, GameObject.Find ("FoodValueLow").transform);
        } else {
            //don't give out food
            //play sad trombone sound
            if (audiosource != null && trombones > 0) {
                audiosource.Stop ();//stop playing whatever was being played before
                audiosource.PlayOneShot (denySound);
                trombones--;
            }
        }
    }
}
