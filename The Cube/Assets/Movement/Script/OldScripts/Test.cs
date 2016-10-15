using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour 
{
	public float speed = 10.0f;
	public float jumpSpeed = 7.0f;
	public float maxJump = 3.0f;
	static public bool rotate;
	public int jumpCount = 1;
	public Vector3 gravity;
	//	public Vector3 start;
	bool isGrounded = true;
	public bool alive = true;
	public bool begin = true;
	
	public MeshRenderer[] death;
	public BoxCollider[] death2;
	public Rigidbody[] death3;
	
	
	// Use this for initialization
	void Start () 
	{
		//		start = gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Make the object turn 180 degrees
		if(Input.GetKeyDown (KeyCode.RightArrow) && rotate == true)
		{
			transform.RotateAround (transform.position, transform.up, 180f);
			rotate = false;
		}
		
		if (Input.GetKeyDown (KeyCode.LeftArrow) && rotate == false)
		{
			transform.RotateAround (transform.position, transform.up, 180f);
			rotate = true;			
		}
		
		
		//moving an object horizontally and Vertically
		var move = new Vector3 (Input.GetAxis ("Horizontal"), Input.GetAxis ("Vertical"), 0);
		//transform.position += move * speed * Time.deltaTime;
		GetComponent<Rigidbody> ().position += move * speed * Time.deltaTime;
		
		/*		//Jumping with a spacebar
		if (Input.GetKeyDown (KeyCode.Space) && maxJump < 3) 
			
			GetComponent<Rigidbody> ().velocity += Vector3.up * jumpSpeed;
*/
		
		//Jumping with a spacebar
		if (Input.GetKeyDown (KeyCode.Space) && maxJump < 3) 
		{
			GetComponent<Rigidbody> ().velocity += Vector3.up * jumpSpeed;
			jumpCount ++;
		} 
		if (jumpCount > maxJump || isGrounded == false) 
		{
			jumpSpeed = 0.0f;
			
		} 
		if (jumpCount > maxJump && isGrounded == true) 
		{
			jumpSpeed = 0.0f;
			jumpCount = 1;
		}
		//Respawn
		if (alive == false) 
		{
			StartCoroutine (CoroutineFunction());
		}
		
		//Respawn 2
		if (begin == false) 
		{
			StartCoroutine (CoroutineFunction2());
		}
	}
	
	
	void OnCollisionEnter(Collision col)
	{
		
		if (col.gameObject.tag == "ground")     
		{
			jumpCount = 1;
			jumpSpeed = 7.0f;
		}
		//Respawn
		if (col.gameObject.tag == "enemy") 
		{
			alive = false;
		}
		
		//Respawn2
		if (col.gameObject.tag == "death") 
		{
			begin = false;
		}
		
	}
	
	//Respawn
	IEnumerator CoroutineFunction ()
	{
		print ("Level 2");
		gameObject.transform.position = (GameObject.FindWithTag ("Spawn").transform.position);
		yield return new WaitForSeconds (1f);
		alive = true;
	}
	
	IEnumerator CoroutineFunction2()
	{
		print ("Level 1");
		gameObject.transform.position = (GameObject.FindWithTag ("Start").transform.position);
		yield return new WaitForSeconds (1f);
		begin = true;
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (gameObject.tag == "Player")
		{
			StartCoroutine(Respawn());
		}
	}
	
	IEnumerator Respawn ()
	{
		if (gameObject.tag == "Player")
		{
			death = gameObject.GetComponentsInChildren<MeshRenderer> ();
			death2 = gameObject.GetComponentsInChildren<BoxCollider> ();
			death3 = gameObject.GetComponentsInChildren<Rigidbody> ();
			foreach(MeshRenderer mesh in death)
				mesh.enabled = false;
			foreach(BoxCollider mesh in death2)
				mesh.enabled = false;	
			foreach(Rigidbody mesh in death3)
				mesh.useGravity = false;
			
			
			yield return new WaitForSeconds(2);
			
			gameObject.transform.position = (GameObject.FindWithTag ("Spawn").transform.position);
			
			foreach (MeshRenderer mesh in death)
				mesh.enabled = true;
			foreach (BoxCollider mesh in death2)
				mesh.enabled = true;
			foreach (Rigidbody mesh in death3)
				mesh.useGravity = true;
		}
	}
	
}
