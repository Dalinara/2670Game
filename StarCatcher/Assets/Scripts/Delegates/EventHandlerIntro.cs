using UnityEngine;
using System.Collections;

public class EventHandlerIntro : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		DelegateIntro.MyEvent += MyEventHandler;
		DelegateIntro.EventWithArgs += EventWithArgsHandler;
		DelegateIntro.EventString += EventStringHandler;
		DelegateIntro.EventReturnArgs += EventReturnArgsHandler;
	}

	private void MyEventHandler()
	{
		print ("Ran");
	}

	private void EventWithArgsHandler(string s)
	{
		print (s);
	}

	private string EventStringHandler()
	{
		print ("Do you like cats?");
		return "I like cats.";
	}

	private string EventReturnArgsHandler(string s)
	{
		return "The animal I like the most is " + s;
	}

}
