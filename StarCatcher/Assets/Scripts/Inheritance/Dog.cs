using UnityEngine;
using System.Collections;

public class Dog : Animal 
{
	void Bark()
	{
		print ("Bark");
	}

	public override void Start()
	{
		Bark ();
		base.Start ();
	}
}
