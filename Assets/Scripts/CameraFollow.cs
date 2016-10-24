using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	private Vector3 offset;
	//private int lag = 10;
	public float xlag;
	public float zlag;
	public float cameradist;
	public GameObject player;
	// Use this for initialization
	void Start () {
		offset = GetComponent<Camera>().transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 newCameraPosition = player.transform.position + offset;
		newCameraPosition.y = cameradist;
		if (GetComponent<Camera>().transform.position.x - newCameraPosition.x > xlag) {
			GetComponent<Camera> ().transform.position = newCameraPosition + new Vector3 (xlag, 0, 0);
		}
		if (GetComponent<Camera>().transform.position.x - newCameraPosition.x < -xlag) {
			GetComponent<Camera> ().transform.position = newCameraPosition + new Vector3 (-xlag, 0, 0);
		} 
		if (GetComponent<Camera>().transform.position.z - newCameraPosition.z > zlag) {
			GetComponent<Camera> ().transform.position = newCameraPosition + new Vector3 (0, 0, zlag);
		}
		if (GetComponent<Camera>().transform.position.z - newCameraPosition.z < -zlag) {
			GetComponent<Camera> ().transform.position = newCameraPosition + new Vector3 (0, 0, -zlag);
		}
	}
}
