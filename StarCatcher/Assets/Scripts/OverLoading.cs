using UnityEngine;
using System.Collections;

public class OverLoading : MonoBehaviour 
{

	// Use this for initialization
	void Update () 
	{
		Move (50);
		Move ("slow");
	}

	void Move(int speed)
	{
		Vector3 vector = new Vector3(speed, 0, 0);
		transform.position = vector * Time.deltaTime;
	}

	//Method overloading. Overloading the type that we're taking.
	void Move(string speed)
	{
		Vector3 vector = Vector3.zero;
		switch (speed) 
		{
			case "fast":
				vector = new Vector3(100, 0, 0);
				break;
			case "slow":
				vector = new Vector3(1, 0, 0);
				break;
		}
		transform.position = vector * Time.deltaTime;
	}
}
