using UnityEngine;
using System.Collections;

public class ScoreControl : MonoBehaviour 
{

	// Initialize the score and start the coroutine.
	void Start () 
	{
		StaticVars.score = PlayerPrefs.GetInt ("Score");
		StartCoroutine (AddToScore ());
	}

	//Add to the score until you tell it that you're done.
	IEnumerator AddToScore()
	{
		StaticVars.score++;
		yield return new WaitForSeconds (1);
		print (StaticVars.score);
		StartCoroutine (AddToScore ());
	}

	//At the end of the game save the score and then print it.
	void OnDisable()
	{
		PlayerPrefs.SetInt("Score", StaticVars.score);
		print("Final Score " + PlayerPrefs.GetInt("Score"));
		print ("Game Over");
	}
}
