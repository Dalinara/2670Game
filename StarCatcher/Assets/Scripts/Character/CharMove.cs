using UnityEngine;
using System.Collections;

public class CharMove : MonoBehaviour 
{
	private CharacterController cc;
	public Vector3 moveDirection;
	public float jumpSpeed = 10;
	public float gravity = 1;
	public float speed = 10;

	// Use this for initialization
	void Start ()
	{
		cc = GetComponent<CharacterController> ();
		MoveUsingArrowKeys.MoveOnArrows += Move;
		MoveUsingArrowKeys.RotateOnArrows += Rotate;
	}

	void Rotate(int _rotateInY)
	{
		//Transform.Rotate (0, _rotateInY, 0);

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
			//moveDirection - transform.TransformDirection (moveDirection * speed * Time.deltaTime);
			moveDirection = transform.TransformDirection(moveDirection * Time.deltaTime);
			cc.Move (moveDirection);
		}
	}
}
