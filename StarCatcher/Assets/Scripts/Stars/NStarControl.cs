﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class NStarControl : MonoBehaviour 
{
	public List<Transform> spawners;
	public List<Transform> stars;

	void SpawnHandler(Transform _t)
	{
		spawners.Add (_t);
	}

	void StarHandler(Transform _t)
	{
		stars.Add (_t);
	}

	// Use this for initialization
	void Start () 
	{
		StarSpawner.SendSpawner += SpawnHandler;
		Star.SendStar += StarHandler;
		if (stars != null || spawners != null) 
		{
			StartCoroutine (Spawn ());
		}
	}

	private bool canSpawn = true;
	private int starNum = 0;
	private int spawnerNum = 0;

	IEnumerator Spawn()
	{
		while (canSpawn) 
		{
			yield return new WaitForSeconds (2);
			stars [starNum].position = spawners [spawnerNum].position;
			stars[starNum].GetComponent<MeshRenderer> ().enabled = true;
			if (starNum < stars.Count - 1) 
			{
				starNum++;
			}else 
			{
				starNum = 0;
			}
			if (spawnerNum < spawners.Count - 1) 
			{
				spawnerNum++;
			}else 
			{
				spawnerNum = 0;
			}
		}
	}
}
