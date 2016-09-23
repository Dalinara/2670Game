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
		i = UnityEngine.Random.Range(0, recyclableList.Count - 1);
		newLocation.x = StaticVars.nextSectionPos;
		recyclableList[i].cube.position = newLocation;
		StaticVars.nextSectionPos += StaticVars.distance;
		if (recyclableList.Count > 0) 
		{
			recyclableList.RemoveAt(i);
		}
//		i = UnityEngine.Random.Range(0, recyclableList.Count - 1);
	}
}
