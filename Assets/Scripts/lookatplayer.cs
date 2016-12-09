using UnityEngine;
using System.Collections;

public class lookatplayer : MonoBehaviour {
    public GameObject player;
    public GameObject planet;
    private float distance = 50;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(player.transform);
        Vector3 direction = player.transform.position - planet.transform.position;
        transform.position = direction.normalized * distance + player.transform.position;
    }
}
