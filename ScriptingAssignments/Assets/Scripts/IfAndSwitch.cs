using UnityEngine;
using System.Collections;

public class IfAndSwitch : MonoBehaviour
{
	public static int life = 3;
	//Vector 3 to store the position
	Vector3 spawnPoint;
	// Use this for initialization
	void Start () 
	{
		//GameObject that will find the object tagged "Respawn" in the game
		GameObject spawnObject = GameObject.FindGameObjectWithTag ("Respawn");
		//set the spawnPoint to the object
		spawnPoint = spawnObject.transform.position;
	}
	//OnTriggerEnter method that will run when the player runs into an object tagged "Wall"
	void OnTriggerEnter(Collider other)
	{
		//Respawn if the player hits a wall
		if (other.gameObject.tag == "Wall") 
		{
			//Moves the player back to the Respawn position
			transform.position = spawnPoint;
			life--;
		}
	}
}
