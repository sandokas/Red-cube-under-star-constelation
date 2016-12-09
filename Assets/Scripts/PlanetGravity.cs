using UnityEngine;
using System.Collections;

public class PlanetGravity : MonoBehaviour {
    public float gravityForce = 98f;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        GameObject[] pullable = GameObject.FindGameObjectsWithTag("pullable");
        foreach (GameObject gameObject in pullable)
        {
            Vector3 direction = gameObject.transform.position - transform.position;
            gameObject.GetComponent<Rigidbody>().AddForce(direction.normalized * gravityForce * Time.deltaTime);

        }
    }
}
