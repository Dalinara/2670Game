using UnityEngine;
using System.Collections;

public class Variables : MonoBehaviour 
{
	string varTypes = "There are many different types of variables. This is a string variable.";
	string ex02 = "Next is an example of an int.";
	int example = 52;
	// Use this for initialization
	void Start () 
	{
		Debug.Log (varTypes);
		print (ex02);
		print (example);
	}
	
	// Update is called once per frame
	void Update () 
	{
	}
}
