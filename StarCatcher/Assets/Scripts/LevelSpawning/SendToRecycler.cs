using UnityEngine;
using System.Collections;
using System;

public class SendToRecycler : MonoBehaviour 
{
	//Delegate that will pass an object of this class
	public static Action<SendToRecycler> SendThis;
	//Bool for what can be in the list of recyclable objects
	public bool canRecycle = false;

	// Use this for initialization
	void Start () 
	{
		if (canRecycle && SendThis != null) 
		{
			//Call and pass the object
			SendThis (this);
		}
	}

	void OnTriggerEnter()
	{
		canRecycle = true;
		Start ();
	}
}
