using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DogBounce : MonoBehaviour {

    public float yMax = 5;
    public float yMin = 0;
    public float bounceRateUp = 0.2f;
    public float bounceRateDown = 0.5f;
    bool direction = true;
    float currentY;
    public int waitTime = 5;//how long to show the screen before input can reset the game
    float startTime = 0;

	// Use this for initialization
	void Start () {
        currentY = yMin;
        startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
        if (direction) {
            // doggy goes up
            currentY += bounceRateUp;
            if (currentY >= yMax) {
                currentY = yMax;
                direction = false;
            }
            this.transform.position = new Vector3 (this.transform.position.x, currentY, this.transform.position.z);
        } else {
            //doggy goes down
            currentY -= bounceRateDown;
            if (currentY <= yMin) {
                currentY = yMin;
                direction = true;
            }
            this.transform.position = new Vector3 (this.transform.position.x, currentY, this.transform.position.z);
        }

        if (Input.anyKey && Time.time >= startTime + waitTime) {
            SceneManager.LoadScene ("MainGame");
        }
	}
}
