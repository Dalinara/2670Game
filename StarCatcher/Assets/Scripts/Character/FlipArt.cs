﻿using UnityEngine;
using System.Collections;

public class FlipArt : MonoBehaviour 
{
	public Transform characterArt;
	public bool forward = true;

	void FlipCharacter(bool _b)
	{
		characterArt.Rotate(0, 180, 0);
		forward = _b;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.RightArrow) && !forward) 
		{
			FlipCharacter (true);
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow) && forward) 
		{
			FlipCharacter(false);
		}
		if (Input.GetKeyDown (KeyCode.D) && !forward) 
		{
			FlipCharacter (true);
		}
		if (Input.GetKeyDown (KeyCode.A) && forward) 
		{
			FlipCharacter(false);
		}
	}
}
