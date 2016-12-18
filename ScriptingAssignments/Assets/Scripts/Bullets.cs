using UnityEngine;
using System.Collections;

public class Bullets : MonoBehaviour 
{
	public GameObject bullet;
	float time = 3;
	float bulletSpeed = 2;
	Vector3 tempPos;
	CharacterController cc;

	// Use this for initialization
	void Start () 
	{
		cc = GetComponent<CharacterController> ();
	}

	void Update()
	{
		tempPos.x += bulletSpeed * Time.deltaTime;
		cc.Move (tempPos);
	}

	void OnCollisionEnter()
	{
		Destroy (this);
	}



}
