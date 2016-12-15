using UnityEngine;
using System.Collections;

public class QuitButton : UIBase 
{
	public GameObject mainMenu;

	// Use this for initialization
	void Start () 
	{
	
	}

	public void LoadElement(int mainMenu)
	{
		Application.LoadLevel (mainMenu);
	}

}
