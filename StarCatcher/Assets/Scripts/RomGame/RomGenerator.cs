using UnityEngine;
using System.Collections;

public class RomGenerator : MonoBehaviour
{
	public int agentCount;
	NavMesh navPen;
	ArrayList RecycleList();

	void Start()
	{
		
	}

	private void AddToList(NavMesh obj)
	{
		RecycleList.Add (obj);
		obj.transform.position = navPen.position
	}

	IEnumerator RecycleColors()
	{
		while (agentCount < 0) 
		{

		}
	}


	// Update is called once per frame
	void Update () {
	
	}
}
