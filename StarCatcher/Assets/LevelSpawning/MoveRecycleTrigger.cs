using UnityEngine;
using System.Collections;

public class MoveRecycleTrigger : MonoBehaviour 
{
	//A temporary position for the object
	private Vector3 movePos; 
	//Speed variable for the recycle trigger
	public float speed = 1; 

	// Update is called once per frame 
	void Update () 
	{
		//Moves by the speed at a consistent rate
		movePos.x = speed * Time.deltaTime; 
		//Move the object to the temp position
		transform.Translate (movePos); 
	}
}
