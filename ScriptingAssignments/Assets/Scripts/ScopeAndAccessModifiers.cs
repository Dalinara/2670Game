using UnityEngine;
using System.Collections;

public class ScopeAndAccessModifiers : MonoBehaviour 
{
	//a public int for the maximum health
	public int maxHealth = 10;
	//Temporary health
	private int tempHealth = 10;


	private Vector3 tempPos;
	// Use this for initialization
	void Start () 
	{
		print ("Your current health is " + tempHealth); 
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	//OnTriggerEnter to take away the character's health
	void OnTriggerEnter(Collider other)
	{
		//if statement to lose health when the character hits a wall
		if (other.gameObject.tag == "Wall") 
		{
			//Decrement health
			tempHealth--;
			//Print the character's health
			print("Your current health is " + tempHealth);
		}
		if(tempHealth == 0)
		{
			print ("Your character is dead.");
		}
	}
}
