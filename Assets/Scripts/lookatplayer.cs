using UnityEngine;
using System.Collections;

public class LookAtPlayer : MonoBehaviour {
    public GameObject player;
    public GameObject planet;
    public GameObject front;
    private float distance = 50;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 forward =  player.transform.position - planet.transform.position;
        Vector3 up =  front.transform.position - player.transform.position;
        transform.position = forward.normalized * distance + player.transform.position;
        //transform.LookAt(player.transform);
        transform.rotation = Quaternion.LookRotation(-forward.normalized, up.normalized);
    }
}
