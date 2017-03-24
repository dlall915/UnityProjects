using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	
	public GameObject player;
	
	private Vector3 offset;

	// Use this for initialization
	void Start () {
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	// LateUpdate runs after all Updates, this is important so that the camera moves
	// only if the player has actually moved.
	void LateUpdate () {
		transform.position = player.transform.position + offset;
	}
}
