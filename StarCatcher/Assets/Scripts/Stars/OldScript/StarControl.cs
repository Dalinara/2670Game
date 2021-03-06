﻿using UnityEngine;
using System.Collections;

public class StarControl : MonoBehaviour 
{
	public int forceTime = 10;
	public float endTime = 3;
	private bool canAddForce = true;
	public float forceDuration = 0.1f;
	private Rigidbody rigid;
	private float force;
	private Vector3 forceVector;
	public float forceRange = 50;
	private Vector3 torqueVector;
//	private Animator anims;

	void Start () 
	{
		rigid = GetComponent<Rigidbody>();
		StartCoroutine (RunRandomForce());
//		anims = GetComponent<Animator>;
	}

	void OnCollisionEnter ()
	{
//		Destroy (gameObject, endTime);
		gameObject.SetActive(false);
//		canAddForce = false;
//		anims.SetBool("Destroy", true);
	}

//	public void Deactivate()
//	{
//		anims.SetBool ("Destroy", false);
//		gameObject.SetActive (false);
//
//	}

	IEnumerator RunRandomForce()
	{
		force = Random.Range(-forceRange, forceRange);
		while (forceTime > 0) 
		{
			yield return new WaitForSeconds (forceDuration);
			forceVector.x = force;
			torqueVector.z = -(force * 0.2f);
			rigid.AddForce(forceVector);
			rigid.AddTorque (torqueVector);
			forceTime--;
		}
	}
}
