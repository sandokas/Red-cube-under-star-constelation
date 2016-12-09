using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float force;
	Rigidbody rb;

    void Start () {
		rb = GetComponent<Rigidbody> ();
	}

	void Update () {
        Vector3 forceToAdd = Vector3.zero;

        if (Input.GetKey (KeyCode.Space)) {
            forceToAdd = Vector3.up * force * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.D)) {
            forceToAdd = Vector3.right * force * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A)) {
            forceToAdd = Vector3.left * force * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W)) {
            forceToAdd = Vector3.forward * force * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S)) {
            forceToAdd = Vector3.back * force * Time.deltaTime;
        }
        rb.AddRelativeForce(forceToAdd,ForceMode.Force);

    }
}

