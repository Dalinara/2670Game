using UnityEngine;
using System.Collections;
using System;

public class RomResetGame : MonoBehaviour 
{
	public static Action ResetLevel;

	// Use this for initialization
	void Start () 
	{
		EndGame.GameOver += ResetLevel;
	}



}
