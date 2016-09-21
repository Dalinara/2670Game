using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RecycleLevelComponent : MonoBehaviour 
{
	private Vector3 newLocation;
	public List<Recycler> recyclableList;
	private int i = 0;

	void Start()
	{
		recyclableList = new List<Recycler> ();
		Recycler.recycleAction += RecycleActionHandler;
	}

	private void RecycleActionHandler(Recycler _r)
	{
		recyclableList.Add (_r);
	}

	void OnTriggerEnter()
	{
		newLocation.x = StaticVars.nextSectionPos;
		recyclableList[i].cube.position = newLocation;
		StaticVars.nextSectionPos += StaticVars.distance;
		if (i < recyclableList.Count - 1) 
		{
			i++;
		}
	}
}
