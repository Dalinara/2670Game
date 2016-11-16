using UnityEngine;
using System.Collections;

public class EnemyShip : ShipBase 
{
	private void Chase()
	{
		print ("Chasing");
	}
	// Use this for initialization
	void Start () 
	{
		base.Start ();
		Chase ();
	}

}
