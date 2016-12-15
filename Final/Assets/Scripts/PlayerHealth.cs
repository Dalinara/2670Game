using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour 
{
	public GameObject deathScreen;
	int playerHealth = 100;
	Action healthBar;
	Action killPlayer;
	public Slider healthSlider;

	// Use this for initialization
	void Start () 
	{
//		healthBar = HealthBarHandler ();
//		killPlayer = KillPlayerHandler ();
		deathScreen.SetActive (false);
	}

	void OnCollisionEnter()
	{
		healthSlider.value = playerHealth;
		playerHealth--;
		healthSlider.value = playerHealth;	
	}
//
//	//Work with the health bar slider
//	void HealthBarHandler()
//	{
//		healthSlider.value = playerHealth;
//		playerHealth--;
//		healthSlider.value = playerHealth;
//	}
//
//	void KillPlayerHandler()
//	{
//		print ("You have died");
//		if (playerHealth == 0) 
//		{
//			deathScreen.SetActive (true);
//		}
//	}

}
