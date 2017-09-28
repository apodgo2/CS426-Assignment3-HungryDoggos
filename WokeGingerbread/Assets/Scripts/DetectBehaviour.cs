using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectBehaviour : MonoBehaviour {

    public float detectionRange;
    public float distance;
    public static bool withinRange = false;
    // Use this for initialization
    void Start () {
        detectionRange = 15;
    }
	
	// Update is called once per frame
	void Update () {
        distance = Vector3.Distance(GameObject.Find("dog").transform.position, GameObject.Find("gingerperson").transform.position);
        //Debug.Log("Distance " + distance);
		if (distance <= detectionRange) {
			//Debug.Log ("Within Range");
            withinRange = true;
		} else {
			//Debug.Log ("Out of Range");
            withinRange = false;
		}
	}

    public static GameObject getClosest() {
        //this function SHOULD return the closest possible Gingerperson instance, but since we only have one
        //I'm just using GameObject.Find() same as above. 
        return (GameObject) GameObject.Find ("gingerperson");
    }
}
