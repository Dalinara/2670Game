using UnityEngine;
using System.Collections;

public class LightPowerUp : MonoBehaviour , IPowerUp
{
	public GameObject torchLight;

	void Start()
	{
		torchLight.SetActive (false);
	}

	void OntriggerEnter()
	{
		torchLight.SetActive (true);
	}

}
