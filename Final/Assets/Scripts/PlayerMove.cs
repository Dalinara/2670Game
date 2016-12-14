using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour 
{
	private CharacterController cc;
	public Vector3 moveDirection;
	public float speed = 10;
	public float jumpSpeed = 10;
	public float gravity = 1;

	// Use this for initialization
	void Start () 
	{

	}

	public void Forward()
	{
		moveDirection.x = speed * Time.deltaTime;
		cc.Move(moveDirection);
	}

	public void MoveSide()
	{
		moveDirection.z = speed * Time.deltaTime;
		cc.Move (moveDirection);
	}

//	public void RotateRight()
//	{
//		transform.Rotate(Vector3.right * Time.deltaTime);
//	}

//	public void RotateLeft()
//	{
//		transform.Rotate (Vector3.left * Time.deltaTime);
//	}

}
