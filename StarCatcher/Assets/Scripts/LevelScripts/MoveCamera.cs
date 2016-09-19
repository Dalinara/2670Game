using UnityEngine;
using System.Collections;

public class MoveCamera : MonoBehaviour 
{
	//speed that the camera will move at
	public float speed = 1;
	//Private vector3 for the temporary position
	private Vector3 tempPos;
	
	// Update is called once per frame
	//Move the camera
	void Update () 
	{
		//Have the tempPos move along the x-axis at the speed, and make it consistent using Time.deltaTime
		tempPos.x = speed * Time.deltaTime;
		//Have the camera be the tempPos
		transform.Translate (tempPos); 
	}
}
