using UnityEngine;
using System.Collections;

public class MenuButton : MonoBehaviour 
{
	public GameObject quitButton;
	public GameObject resumeButton;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	void OnClickEnter()
	{
		quitButton.SetActive (true);
		resumeButton.SetActive (true);
	}
}
