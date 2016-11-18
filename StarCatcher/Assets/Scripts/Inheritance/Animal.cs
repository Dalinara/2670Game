using UnityEngine;
using System.Collections;

public class Animal : MonoBehaviour 
{

	// Use this for initialization
	public virtual void Start ()
	{
		Walk ();
	}

	void Walk()
	{
		print ("Walking");
	}
}
