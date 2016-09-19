using UnityEngine;
using System.Collections;

public class RecycleLevelComponent : MonoBehaviour 
{
	private Vector3 newLocation;

	void OnTriggerEnter()
	{
//		print ("Hit!");
		newLocation.x = StaticVars.nextSectionPos;
		transform.position = newLocation;
		StaticVars.nextSectionPos += StaticVars.distance;

	}
}
