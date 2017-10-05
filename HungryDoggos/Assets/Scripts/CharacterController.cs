using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterController : MonoBehaviour {

	public float speed = 2500.0f;
	public float rotationSpeed = 90;
	public float force = 700f;

	public GameObject cannon;
	public GameObject bullet;
	public Score scoreManager;
    public Doggo doggoscript;

	public CAVE2.Axis forwardAxis = CAVE2.Axis.LeftAnalogStickUD;

	//declaring pointers to Rigidbody & Transform objects
	Rigidbody rb; 
	Transform t;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		t = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {


		if (Input.GetKey (KeyCode.W) || CAVE2.GetButtonDown(1, CAVE2.Button.ButtonUp))
			//rb.velocity += this.transform.right * speed * Time.deltaTime;
            transform.Translate (Vector3.right * speed * Time.deltaTime);
		else if (Input.GetKey(KeyCode.S) || CAVE2.GetButtonDown(1, CAVE2.Button.ButtonDown))
			//rb.velocity -= this.transform.right * speed * Time.deltaTime;
            transform.Translate (Vector3.left * speed * Time.deltaTime); //should probably use AddForce instead of this, but it's late.

		if (Input.GetKey (KeyCode.D)|| CAVE2.GetButtonDown(1, CAVE2.Button.ButtonRight))
			t.rotation *= Quaternion.Euler(0, rotationSpeed * Time.deltaTime, 0);
		else if (Input.GetKey(KeyCode.A)|| CAVE2.GetButtonDown(1, CAVE2.Button.ButtonLeft))
			t.rotation *= Quaternion.Euler(0, - rotationSpeed * Time.deltaTime, 0);


		/*if (Input.GetKey (KeyCode.B)) { // old gingerbread bullet code:
			GameObject newBullet = GameObject.Instantiate (bullet, cannon.transform.position, cannon.transform.rotation) as GameObject;
			newBullet.GetComponent<Rigidbody> ().velocity += Vector3.up * 10;
			newBullet.GetComponent<Rigidbody> ().AddForce (newBullet.transform.forward * 1500);
		}*/

		if (Input.GetKey (KeyCode.B) || CAVE2.GetButtonDown(1, CAVE2.Button.Button7)) {
            //BARK!
            doggoscript.bark ();
        }
			

		if (Input.GetKeyDown (KeyCode.Space))
			rb.AddForce (t.up * force);// so this doesn't work probably because the dog is made of a bunch of components. maybe make the dog a prefab then apply force?

		if (Input.GetKey (KeyCode.R)|| CAVE2.GetButtonDown(1, CAVE2.Button.Button1)) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}

	}
}
