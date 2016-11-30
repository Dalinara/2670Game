using UnityEngine;
using System.Collections;

public class MoreHandlers : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		DelegateIntro.EventString += ES;
		DelegateIntro.MyEvent += ME;
		DelegateIntro.EventWithArgs += EA;
		DelegateIntro.EventReturnArgs += ERA;
	}

	public string ES()
	{
		return "Dogs are better";
	}

	public void ME()
	{
		print ("Cool Beans");
	}

	public void EA(string obj)
	{
		print ("But I love " + obj);
	}

	public string ERA(string arg1)
	{
		return "I love " + arg1 + "too";
	}

}
