using UnityEngine;
using System.Collections;

public class LightPowerUp : MonoBehaviour , IPowerUp
{
	public GameObject torchLight;
	public GameObject lightSlider;
	int torchTime = 90;

	void Start()
	{
		torchLight.SetActive (false);
	}

	public IEnumerator OnTriggerEnter ()
	{
		torchLight.SetActive (true);
		lightSlider.SetActive (true);
		yield return new WaitForSeconds (torchTime);
		torchLight.SetActive (false);
	}
		
}
