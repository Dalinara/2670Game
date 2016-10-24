using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class FindThingsWrong : MonoBehaviour 
{
	public List<GameObject> level;

	// Use this for initialization
	void Start () 
	{
		//This makes it search through all the objects, and it takes too long. Don't use 'Find' in any form.
		GameObject temp = GameObject.Find ("Plane");
		level.Add (temp);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
