using UnityEngine;
using System.Collections;

public class CamMove : MonoBehaviour 
{
	public Transform player;

	// Use this for initialization
	void Start () 
	{
		player = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position = new Vector3 (player.position.x + 0, player.position.y + 0, -20);
	}
}
