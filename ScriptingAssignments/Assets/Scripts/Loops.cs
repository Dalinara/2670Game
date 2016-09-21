using UnityEngine;
using System.Collections;

public class Loops : MonoBehaviour 
{
	Vector3 spawnPoint;

	// Use this for initialization
	void Start () 
	{
		
		//GameObject that will find the object tagged "Respawn" in the game
		GameObject spawnObject = GameObject.FindGameObjectWithTag ("Respawn");
		//set the spawnPoint to the object
		spawnPoint = spawnObject.transform.position;

	}
	//

	// Update is called once per frame
	void Update () 
	{
		//Do While loop to tell the player how many lives they have
		do 
		{
			//Tell the player how many lives they have left
			print ("You have " + IfAndSwitch.life + " lives left");
		} while(IfAndSwitch.life >= 0);
	}
}
