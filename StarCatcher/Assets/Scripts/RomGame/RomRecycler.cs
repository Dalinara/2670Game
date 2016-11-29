using UnityEngine;
using System.Collections;

public class RomRecycler : MonoBehaviour 
{

	public static Action<NavAgent> SendToGenerator;
	public NavAgent navAgent;


	// Use this for initialization
	void Start ()
	{
		SendToGenerator (navAgent);
	}

	void OnTriggerEnter()
	{
		navAgent.
	}
}
