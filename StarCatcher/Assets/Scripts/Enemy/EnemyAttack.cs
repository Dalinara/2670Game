using UnityEngine;
using System.Collections;

public class EnemyAttack : MonoBehaviour, IAttack, IDamage
{
	public void Damage ()
	{
		print ("Damage all");	
	}
		
	public void Attack ()
	{
		print ("I attack");
	}

	// Use this for initialization
	void Start () 
	{
		Attack ();
		Damage ();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
