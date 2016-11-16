using UnityEngine;
using System.Collections;

public class DamagingPowerUp : MonoBehaviour, IDamage 
{
	public void Damage ()
	{
//		throw new System.NotImplementedException ();
		print ("Damage Player");
	}

	// Use this for initialization
	void Start () 
	{
		Damage ();
	}

}
