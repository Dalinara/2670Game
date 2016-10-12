using UnityEngine;
using System.Collections;
using System;

public class GameControl : MonoBehaviour 
{
	public static Action startGame;
	public static Action endGame;

	public void StartGameCall ()
	{
		print ("Start Game");
		if (startGame != null) 
		{
			startGame ();
		}
	}

}
