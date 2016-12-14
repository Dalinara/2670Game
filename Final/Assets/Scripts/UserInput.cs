using UnityEngine;
using System.Collections;

public class UserInput : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) 
		{
			PlayerMove.Forward ();
		}

		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) 
		{
			transform.Rotate(Vector3.right * Time.deltaTime);
		}

		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) 
		{
			transform.Rotate (Vector3.left * Time.deltaTime);
		}
	}
}
