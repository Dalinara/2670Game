using UnityEngine;
using System.Collections;
//Includes both MonoBehaviour and the IPowerUp script, so it needs to include everything that the IPowerUp script requires.
public class HealthPowerUp : MonoBehaviour, IPowerUp 
{
	public void Start ()
	{
		throw new System.NotImplementedException ();
	}

	public void OnTriggerEnter ()
	{
		throw new System.NotImplementedException ();
	}

	public int power 
	{
		get 
		{
			throw new System.NotImplementedException ();
		}
	}
		
}
