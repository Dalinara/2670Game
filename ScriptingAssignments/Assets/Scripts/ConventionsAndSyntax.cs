using UnityEngine;
using System.Collections;

public class ConventionsAndSyntax : MonoBehaviour 
{
	//Stores reference to the player game object. 
	private GameObject player; 
	//Vector3 variable to store the distance of the camera from the player. 
	private Vector3 offset; 

	// Use this for initialization 
	void Start () 
	{
		//Finds game object with the tag "player" and sets it as the player variable. 
		player = GameObject.FindGameObjectWithTag ("Player"); 
		offset = transform.position - player.transform.position; 
	}
	
	// Update is called once per frame
	void Update () 
	{
		//Follows the player while maintaining its distance from the player. 
		transform.position = player.transform.position + offset; 
	}
}
