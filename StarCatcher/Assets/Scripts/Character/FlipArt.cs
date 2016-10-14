using UnityEngine;
using System.Collections;

public class FlipArt : MonoBehaviour 
{
	public Transform characterArt;
	public bool forward = true;

	void FlipCharacter(KeyCode _keyCode)
	{
		switch (_keyCode) 
		{
			case KeyCode.RightArrow:
				if (!forward) 
				{
					characterArt.Rotate (0, 180, 0);
					forward = true;
				}
				break;
			case KeyCode.LeftArrow:
				if (forward) 
				{
					characterArt.Rotate (0, 180, 0);
					forward = false;
				}
				break;
			case KeyCode.UpArrow:
					print ("Up");
				break;
			case KeyCode.DownArrow:
				print ("Down");
				break;
			default:
				print ("No correct input");
				break;
		}
//		characterArt.Rotate(0, 180, 0);

	}

	void StopScript()
	{
		UserInput.userInput -= FlipCharacter;
	}

	void Start()
	{
		EndGame.GameOver += StopScript;
		UserInput.userInput += FlipCharacter;
	}

}
