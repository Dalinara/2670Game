using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour 
{
	//string array of possible weapons
	public string [] weapons = {"sword", "gun", "dagger", "bow", "staff"};
	//int to count the number in the array
	int i = 0;

	// Use this for initialization
	void Start () 
	{
		print ("Press 'Z' to switch your weapon.");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Z) && i < weapons.Length) 
		{
			print ("You have equiped your " + weapons[i]);
			i++;
		}
		if (i == weapons.Length) 
		{
			i = 0;
		}
	}
}
