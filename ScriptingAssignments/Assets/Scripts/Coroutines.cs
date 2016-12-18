using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Coroutines : MonoBehaviour 
{
	public GameObject bullet;
	float spawnTime = 5;


	// Use this for initialization
	void Start () 
	{
		StartCoroutine (SpawnBullets ());
	}

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			StartCoroutine (SpawnBullets ());
		}
	}

	IEnumerator SpawnBullets()
	{
		yield return new WaitForSeconds (spawnTime);
		Instantiate (bullet);
	}

}
