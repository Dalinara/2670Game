using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LightPowerUp : MonoBehaviour , IPowerUp
{
	public GameObject torchLight;
	public Slider lightSlider;
	int lightAmount = 60;
	int torchTime = 90;
	bool lightOn = false;

	void Start()
	{
		torchLight.SetActive (false);
	}

	public void OnTriggerEnter ()
	{
		StartCoroutine (AddLight());
	}

	IEnumerator AddLight()
	{
		torchLight.SetActive (true);
		lightSlider.value = lightAmount;
		yield return new WaitForSeconds (torchTime);
		lightOn = true;
		while (lightOn = true) 
		{
			yield return new WaitForSeconds (torchTime);
			lightAmount--;
			lightSlider.value = lightAmount;
			if (lightAmount == 0) 
			{
				torchLight.SetActive (false);
				lightAmount = 60;
				lightOn = false;
			}
		}
	}
		
}
