using UnityEngine;
using System.Collections;

public class UserInput : MonoBehaviour , IMove
{
	float rotateSpeed = 30;
	float moveSpeed = 10;
	private CharacterController cc;
	public Vector3 tempPos;

	// Use this for initialization
	void Start () 
	{
		cc = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		;
		if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) 
		{
			transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) 
		{
			transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) 
		{
			transform.Rotate (Vector3.down * rotateSpeed * Time.deltaTime);
		}
	}
}
