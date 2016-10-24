using UnityEngine;
using System.Collections;

public class Ambiente : MonoBehaviour {
	public int x;
	public GameObject star;
	public GameObject anchor;
	void Start () {
		//x
		for (int i = 0; i < 100; i++) {
			Instantiate (star, Random.onUnitSphere*x, Quaternion.identity, anchor.transform);
		}
	}
	
	void Update () {
	}
}
