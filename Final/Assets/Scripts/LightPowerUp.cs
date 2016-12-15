using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LightPowerUp : MonoBehaviour , IPowerUp
{
	public GameObject torchLight;

	void Start()
	{
		torchLight.SetActive (false);
	}

	public void OnCollisionEnter ()
	{
		torchLight.SetActive (true);
	}
		
}
