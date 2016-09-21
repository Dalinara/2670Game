using UnityEngine;
using System.Collections;
using System;

public class Recycler : MonoBehaviour 
{
	//Create a delegate
	public static Action<Recycler> recycleAction;
	//
	public bool canBeRecycled = false;
	public Transform cube;

	// Use this for initialization
	void Start () 
	{
		cube = this.GetComponent<Transform> ();
		//Test to see if the delegate is null, and if not run the delegate 
		if (recycleAction != null && canBeRecycled != false) 
		{
			//Send a data type of recycleAction
			recycleAction (this);
		}
	}

	void OnTriggerEnter ()
	{
		canBeRecycled = true;
		Start ();
	}

}
