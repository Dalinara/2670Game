using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class Grounding : MonoBehaviour 
{
	private CharacterController cc;
	private float gravity = -5;
	private Vector3 tempP;
	public Vector3 startPoint;
//	public float speed = 20;

	// Use this for initialization
	void Start () 
	{
		startPoint = transform.position;
		cc = GetComponent<CharacterController> ();
	}

	void OnTriggerEnter()
	{
//		speed *= -1;
		if (cc.velocity.x < 40) 
		{
			gravity *= 1.5f;
		}
//		else if(cc.velocity.x = 40)
//		{
//			gravity *= .5f;
//		}
		transform.position = startPoint;
	}
	
	// Update is called once per frame
	void Update () 
	{
		print (cc.velocity);
		tempP.y = gravity;
		cc.Move(tempP * Time.deltaTime);
		if (cc.isGrounded) 
		{
			tempP.x = -gravity;
		} else 
		{
			tempP.x = 0;
		}
	}
}
