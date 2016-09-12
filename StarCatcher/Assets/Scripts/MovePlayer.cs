using UnityEngine;
using System.Collections;

public class MovePlayer : MonoBehaviour 
{
	//Character speed
	public float speed = 5;
	//Character controller component
	private CharacterController myCC;
	//temp bar of data type vector3 to move the character
	private Vector3 TempPos;
	private float gravity = 3f;
	public float jumpSpeed = 15f;
	public int jumpCount = 0;
	public int jumpCountMax = 1;

	// Use this for initialization
	void Start () 
	{
		//This 'finds' the character controller
		myCC = GetComponent<CharacterController> ();
	}

	void Update()
	{
		//TempPos.y = gravity;
		//Double jump
		if(Input.GetKeyDown(KeyCode.Space) && jumpCount < jumpCountMax)
		{
			//Incrementing the jumpCount by 1
			jumpCount++;
			//Adding the jumpSpeed to the character
			TempPos.y = jumpSpeed;
		}
		//Test if character is grounded, and reset jumpCount if it is
		if (myCC.isGrounded) 
		{
			//Resets jumpCount to 0
			jumpCount = 0;
		}
		//Adding gravity to the y position of the tempPos
		TempPos.y -= gravity;


		//Move the character on the x-axis
		TempPos.x = speed * Input.GetAxis("Horizontal");
		//Move the character on the z-axis
//		TempPos.z = speed * Input.GetAxis ("Vertical");
		//Move it at a consistent speed(Time.deltaTime)
		myCC.Move(TempPos * Time.deltaTime);

	}
}
