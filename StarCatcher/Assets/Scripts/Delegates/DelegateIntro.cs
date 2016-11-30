using UnityEngine;
using System.Collections;
using System;

public class DelegateIntro : MonoBehaviour 
{
//	public delegate void MyDelegate();
	//Events are recommended for when you create a delegate
//	public static MyDelegate MyEvent;
	//This line does the same as the previous two, because an Action is both a delegate and an event.
	public static Action MyEvent;

//	public delegate void DelWithArgs(string s);
//	public static DelWithArgs EventWithArgs;
	public static Action<string> EventWithArgs;

//	public delegate string DelString();
//	public static DelString EventString;
	//A Func is a delegate with a return type
	public static Func<string> EventString;

	//Sends information and receives it back
//	public delegate string DelReturnArgs (string s);
//	public static DelReturnArgs EventReturnArgs;
	public static Func<string, string> EventReturnArgs;

	// Use this for initialization
	void Start () 
	{
		string data = EventReturnArgs ("cats");
		print (data);
		
		print(EventString ());

		EventWithArgs ("Hello World");
		
		//This is to make sure it only runs if there is something there, so it won't give you an error
		if(MyEvent != null)
			MyEvent ();
	}

}
