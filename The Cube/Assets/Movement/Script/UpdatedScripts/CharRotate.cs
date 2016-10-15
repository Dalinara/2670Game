using UnityEngine;
using System.Collections;

public class CharRotate : MonoBehaviour 
{
	public Transform character;
	public bool forward = true;

	void RotatePlayer(KeyCode _k)
	{
		switch (_k) 
		{
			case KeyCode.RightArrow:
				if(!forward)
				{
					character.Rotate (180, 180, 180);
					forward = true;
				}
				break;
			case KeyCode.LeftArrow:
				if(forward)
				{
					character.Rotate (0, 180, 0);
					forward = false;
				}
				break;
			case KeyCode.DownArrow:
				character.localPosition -= new Vector3(0, .5f, 0);
				break;
			default:
				print ("Incorrect input");
				break;
		}
	}
}
