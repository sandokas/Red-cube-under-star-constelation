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
		if (Input.GetKeyUp (KeyCode.Space)) {
			rb.AddForce (new Vector3(0,force,0));
		}
		if (Input.GetKeyUp (KeyCode.D)) {
			rb.AddForce (new Vector3(force,0,0));
		}
		if (Input.GetKeyUp (KeyCode.A)) {
			rb.AddForce (new Vector3(-force,0,0));
		}
		if (Input.GetKeyUp (KeyCode.W)) {
			rb.AddForce (new Vector3(0,0,force));
		}
		if (Input.GetKeyUp (KeyCode.S)) {
			rb.AddForce (new Vector3(0,0,-force));
		}
	}
}

