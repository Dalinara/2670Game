using UnityEngine;
using System.Collections;

public class PlayerRun : MonoBehaviour , IPowerUp
{
	float runSpeed = 2;
	int runTime = 10;
	bool runPower = false;

	// Use this for initialization
	void Start () 
	{
	
	}

	#region IPowerUp implementation
	public void OnTriggerEnter ()
	{
		runPower = true;
		while (runPower == true) 
		{
			StartCoroutine (Run ());
		}
	}
	#endregion		


	public IEnumerator Run()
	{
//		UserInput.moveSpeed *= runSpeed;
		yield return new WaitForSeconds (runTime * Time.deltaTime);
		runPower = false;
	}

}
