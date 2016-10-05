using UnityEngine;
using System.Collections;
using System;

public class UserInput : MonoBehaviour 
{
	public static Action<KeyCode> userInput;

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.RightArrow) && userInput != null) 
		{
			userInput (KeyCode.RightArrow);
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow) && userInput != null) 
		{
			userInput (KeyCode.LeftArrow);
		}
		if (Input.GetKeyDown (KeyCode.UpArrow) && userInput != null) 
		{
			userInput (KeyCode.UpArrow);
		}
		if (Input.GetKeyDown (KeyCode.DownArrow) && userInput != null) 
		{
			userInput (KeyCode.DownArrow);
		}
	}
}
