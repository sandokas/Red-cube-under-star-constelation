using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	public float xlag;
	public float zlag;
    public float ylag;
	public GameObject player;
    private Transform cameraTransform;
	// Use this for initialization
	void Start () {
        cameraTransform = GetComponent<Camera>().transform;
	}
	
	// Update is called once per frame
	void Update () {
		if (Mathf.Abs(cameraTransform.position.x - player.transform.position.x) > xlag) {
            float newX = cameraTransform.position.x - player.transform.position.x  > 0? player.transform.position.x + xlag : player.transform.position.x - xlag;
            cameraTransform.position = new Vector3(newX, cameraTransform.position.y, cameraTransform.position.z);
		}
        if (Mathf.Abs(cameraTransform.position.z - player.transform.position.z) > zlag)
        {
            float newZ = cameraTransform.position.z - player.transform.position.z > 0 ? player.transform.position.z + zlag : player.transform.position.z - zlag;
            cameraTransform.position = new Vector3(cameraTransform.position.x, cameraTransform.position.y, newZ);
        }

    }
}
