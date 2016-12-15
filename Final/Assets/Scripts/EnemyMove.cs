using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour , IMove
{
	public float moveSpeed = 10;
	private NavMeshAgent myAgent;
	public Transform character;

	Transform targetPlayer;
//	float moveSpeed = 10;

	// Use this for initialization
	void Start () 
	{
		myAgent = GetComponent<NavMeshAgent> ();
	}

	void OnCollisionEnter()
	{
		myAgent.destination = character.position;
	}

}
