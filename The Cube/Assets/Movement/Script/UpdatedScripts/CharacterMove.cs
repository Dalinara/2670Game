using UnityEngine;
using System.Collections;

public class CharacterMove : MonoBehaviour 
{
	private float charSpeed = 10;
	private Vector3 tempPos;
	public Transform character;
	private CharacterController myCC;
	private float gravity = 5;
	int jumpCount = 0;
	int jumpMax = 1;
	public float jumpSpeed = 50;

	// Use this for initialization
	void Start () 
	{
		myCC = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKey(KeyCode.RightArrow))
		{
			
		}
		tempPos.y -= gravity;

		tempPos.x = charSpeed * Input.GetAxis ("Horizontal");

		if (Input.GetKeyDown (KeyCode.DownArrow)) 
		{
			character.localPosition -= new Vector3(0, .5f, 0);
		}
		if (Input.GetKeyDown (KeyCode.Space) && jumpCount < jumpMax) 
		{
			tempPos.y = jumpSpeed;
			jumpCount++;
		}
		if (myCC.isGrounded) 
		{
			jumpCount = 0;
		}

		myCC.Move (tempPos * Time.deltaTime);
	}
}
