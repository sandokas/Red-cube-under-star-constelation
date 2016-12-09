using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float force;
	Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			rb.AddRelativeForce (new Vector3(0,force*Time.deltaTime,0));
		}
		if (Input.GetKey(KeyCode.D)) {
            rb.AddRelativeForce(new Vector3(force * Time.deltaTime, 0,0));
		}
		if (Input.GetKey(KeyCode.A)) {
            rb.AddRelativeForce(new Vector3(-force * Time.deltaTime, 0,0));
		}
		if (Input.GetKey(KeyCode.W)) {
            rb.AddRelativeForce(new Vector3(0,0, force * Time.deltaTime));
		}
		if (Input.GetKey(KeyCode.S)) {
            rb.AddRelativeForce(new Vector3(0,0,-force * Time.deltaTime));
		}
	}
}

