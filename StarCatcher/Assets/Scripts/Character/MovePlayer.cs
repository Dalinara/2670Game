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
	public float jumpSpeed = 30f;
	public int jumpCount = 0;
	public int jumpCountMax = 1;
	//Slide amount
	public int slideDuration = 5;
	//Slide time
	public float slideTime = 0.1f;

//	void StopScript()
//	{
//		
//	}

	//Coroutine for sliding the character using the 's' key
	IEnumerator Slide()
	{
		//sets a temp variable equal to the value of the slideDuration
		int durationTemp = slideDuration;
		//Stores speed as a temporary variable
		float speedTemp = speed;
		//while iterations
		//wait for seconds
		//move the character controller
		//While loop runs while the slideDuration is greater than 0
		while(slideDuration > 0)
		{
			
			//Decrement the slideDuration
			slideDuration--;
			//yield holds the coroutine 
			//return "sends" to the coroutine to do an operation while yielding
			//new creates an instance of an object
			//WaitForSeconds is an object that waits for a duration of time
			yield return new WaitForSeconds (slideTime);
			//Double the speed
			speed = speed += speed;
			print ("Sliding");
		}
		//resets the slideDuration so the player can slide again
		slideDuration = durationTemp;
		//Resets speed
		speed = speedTemp;
	}

	// Use this for initialization
	void Start () 
	{
		//This 'finds' the character controller
		myCC = GetComponent<CharacterController> ();
//		StartCoroutine (Slide ());
	}

	void Update()
	{
		//Double jump
		if(Input.GetKeyDown(KeyCode.Space) && jumpCount < jumpCountMax)
		{
			//Incrementing the jumpCount by 1
			jumpCount++;
			//Adding the jumpSpeed to the character
			TempPos.y = jumpSpeed;
		}
		//start sliding to the right
		if (Input.GetKey (KeyCode.RightArrow) && Input.GetKeyDown(KeyCode.S)) 
		{
			//Start the Slide coroutine
			StartCoroutine (Slide ());
		}
		//Slide to the left
		if (Input.GetKey (KeyCode.LeftArrow) && Input.GetKeyDown(KeyCode.S)) 
		{
			//Start the Slide coroutine
			StartCoroutine (Slide ());
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