using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterController : MonoBehaviour {

	public float speed = 25.0f;
	public float rotationSpeed = 90;
	public float force = 700f;

	public GameObject cannon;
	public GameObject bullet;
	public Score scoreManager;

	//declaring pointers to Rigidbody & Transform objects
	Rigidbody rb; 
	Transform t;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		t = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetKey (KeyCode.W))
			rb.velocity += this.transform.right * speed * Time.deltaTime;
		else if (Input.GetKey(KeyCode.S))
			rb.velocity -= this.transform.right * speed * Time.deltaTime;

		if (Input.GetKey (KeyCode.D))
			t.rotation *= Quaternion.Euler(0, rotationSpeed * Time.deltaTime, 0);
		else if (Input.GetKey(KeyCode.A))
			t.rotation *= Quaternion.Euler(0, - rotationSpeed * Time.deltaTime, 0);


		if (Input.GetKey (KeyCode.B)) {
			GameObject newBullet = GameObject.Instantiate (bullet, cannon.transform.position, cannon.transform.rotation) as GameObject;
			newBullet.GetComponent<Rigidbody> ().velocity += Vector3.up * 10;
			newBullet.GetComponent<Rigidbody> ().AddForce (newBullet.transform.forward * 1500);
		}
			

		if (Input.GetKeyDown (KeyCode.Space))
			rb.AddForce (t.up * force);

		if (Input.GetKey (KeyCode.R)) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
}
