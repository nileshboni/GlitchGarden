using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	// Use this for initialization
	public float health=100f;

	public void dealdamage(float damage)
	{
	    health-=damage;
	    if(health<0)
	    {
	       Destroy ();
	    }
	}
	public void Destroy()
	{
	    Destroy(gameObject);
	}
}
