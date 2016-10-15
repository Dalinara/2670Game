using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour 
{
	public GameObject player;
	private Vector3 camPos;

	void Start ()
	{
		camPos = transform.position - player.transform.position;
	}

	// Update is called once per frame
	void Update () 
	{
		transform.position = player.transform.position + camPos;
	}
}
