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
		cc = GetComponent <CharacterController> ();
	}


}
