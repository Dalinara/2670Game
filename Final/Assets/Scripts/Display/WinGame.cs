using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WinGame : MonoBehaviour 
{
	public GameObject winner;

	void Start()
	{
		winner.SetActive (false);
	}

	void OnTriggerEnter()
	{
		print ("You win!");
		winner.SetActive (true);
	}

}
