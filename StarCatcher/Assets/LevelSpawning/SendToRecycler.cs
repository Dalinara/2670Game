using UnityEngine;
using System.Collections;
using System;

public class SendToRecycler : MonoBehaviour 
{
	//Delegate that will pass an object of this class
	public static Action<SendToRecycler> SendThis;

	// Use this for initialization
	void Start () 
	{
		//Call and pass the object
		SendThis(this);
	}
}
