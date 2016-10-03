using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RecycleLevel : MonoBehaviour 
{
	//Store a list of objects used as the level
	public List<SendToRecycler> recycleList;
	//Store a temporary position
	private Vector3 movePos;

	//Recieve the item
	void SendThisHandler(SendToRecycler _r)
	{
		//Add the argument to the list
		recycleList.Add (_r);
	}

	// Use this for initialization
	void Start () 
	{
		//Make a new instance of the list
		recycleList = new List<SendToRecycler> ();
		//Send the object to the container
		SendToRecycler.SendThis += SendThisHandler; 
	}

	//When the object hits a trigger 
	void OnTriggerEnter()
	{
		//Creates a random number, so that it will create a new random number on each trigger
		int i = UnityEngine.Random.Range(0, recycleList.Count - 1);
		//Moves the object to the static position
		movePos.x = Statics.nextPosition;
		//Takes a random item in the list and moves it
		recycleList [i].transform.position = movePos;
		//Removes the current object when it is hit
		recycleList.RemoveAt (i);
		//Adds to the nextPosition so that the objects will continue to move
		Statics.nextPosition += Statics.distance;
	}
}
