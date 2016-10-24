using UnityEngine;
using System.Collections;

public class MoveUsingArrowKeys : MonoBehaviour 
{
	private CharacterController cc;
	public Vector3 moveDirection;
	int jumpSpeed = 10;
	int gravity = 1;
	int speed = 1;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	void Rotate(int _rotateInY)
	{
//		Transform.Rotate (0, _rotateInY, 0);
	}

	void Move(float _moveInZ)
	{
		if (cc.isGrounded) 
		{
			if (Input.GetKey (KeyCode.Space)) 
			{
				print ("jump");
				moveDirection.y += jumpSpeed * Time.deltaTime;
			}
				
			moveDirection.y -= gravity * Time.deltaTime;			

			moveDirection.x = _moveInZ;
//			moveDirection - transform.TransformDirection (moveDirection * speed * Time.deltaTime);
			cc.Move (moveDirection);
		}

	}

	public void MoveOnArrows()
	{

	}

}
