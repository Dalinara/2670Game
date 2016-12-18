using UnityEngine;
using System.Collections;
using System;

public class Delegates : MonoBehaviour 
{
	Action shot;
	Action dying;
	Action death;
	float shotTime = 1;
	float time = 4;

	// Use this for initialization
	void Start () 
	{
		shot = ShotHandler;
	}

	void ShotHandler()
	{
		print ("You have been shot");
		shot = null;
		StartCoroutine (BeenShot ());
	}

	void DyingHandler()
	{
		print ("You are dying");
		dying = null;
		StartCoroutine (DyingSlowly ());
	}

	void DeathHandler()
	{
		print ("You have died");
		death = null;
	}

	IEnumerator BeenShot()
	{
		yield return new WaitForSeconds (shotTime);
		DyingHandler ();
	}

	IEnumerator DyingSlowly()
	{
		yield return new WaitForSeconds (time);
		DeathHandler ();
	}
	void Update()
	{
		if (shot != null) 
		{
			ShotHandler ();
		}
	}

}
