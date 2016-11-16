using UnityEngine;
using System.Collections;

public class PlayerShip : ShipBase 
{
	//Though it doesn't show them, it inherits Attack and Damage from the ShipBase.
	private void Move()
	{
		print ("Moving");
	}

	//You're overriding the base class
	void start()
	{
		Move ();
		base.Start();
	}
}
