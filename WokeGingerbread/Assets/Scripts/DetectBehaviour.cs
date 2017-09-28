using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectBehaviour : MonoBehaviour {

    public float detectionRange;
    public float distance;
    // Use this for initialization
    void Start () {
        detectionRange = 5;
    }
	
	// Update is called once per frame
	void Update () {
        distance = Vector3.Distance(GameObject.Find("dog").transform.position, GameObject.Find("gingerperson").transform.position);
        Debug.Log("Distance " + distance);
		if (distance <= detectionRange) {
			Debug.Log ("Within Range");
		} else {
			Debug.Log ("Out of Range");
		}
	}
}
