using UnityEngine;
using System.Collections;
using System;

public class UpdateAndDelegates : MonoBehaviour 

{
	//Actions are a type of delegate. Delegates contain functions, just as bars contain data.
	Action displayHealth;
	Action killPlayer;
	Action endGame;
	public int health = 250;

	// Use this for initialization
	void Start () 
	{
		//Assign the function displayHealthHandler to the Action displayHealth
		displayHealth = DisplayHealthHandler;
	}

	//Function for the delegate
	void DisplayHealthHandler()
	{
		print ("Health is good.");
		//unassign all functions from displayHealth
		displayHealth = null;
		killPlayer = KillPlayerHandler;
	}

	void KillPlayerHandler()
	{
		print (health);
		health--;
		if (health <= 0)
		{
			killPlayer = null;
			endGame = EndGameHandler;
		}
	}

	void EndGameHandler()
	{
		print ("You died. You didn't even try");
		endGame = null;
	}

	// Update is called once per frame
	void Update ()
	{
		//Check if any function is assigned to displayHealth
		//If nothing is assigned displayHealth won't run
		if (displayHealth != null) 
		{
			//Call the Action
			displayHealth ();
		}
		if (killPlayer != null) 
		{
			killPlayer ();
		}
		if (endGame != null) 
		{
			endGame ();
		}
	}
}
