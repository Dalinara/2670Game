﻿using UnityEngine;
using System.Collections;

public class QuitButton : MonoBehaviour 
{
	public GameObject mainMenu;

	// Use this for initialization
	void Start () 
	{
	
	}

	void LoadMainMenu(int mainMenu)
	{
		Application.LoadLevel (mainMenu);
	}

}