using UnityEngine;
using System.Collections;

public class RotateToPlanet : MonoBehaviour {
    public GameObject planet;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(planet.transform.position,0,Space.Self);
	}
}
