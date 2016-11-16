using UnityEngine;
using System.Collections;

//Parent Class
public class ShipBase : MonoBehaviour, IDamage, IAttack
{
	//All ships can do damage.
	public void Damage ()
	{
		print ("Damage");
	}
		
	//Virtual means it can be overridden in a child class
	//All ships can attack
	public void Attack ()
	{
		print ("Refuel");
		print ("Attacking");
	}
		
	//Protected means that only the child class can see it
	// Use this for initialization
	public virtual void Start () 
	{
		Attack ();
	}

}
