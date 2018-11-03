using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

	// Use this for initialization
	public float speed, damage;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	 {
	      transform.Translate(Vector3.right * speed * Time.deltaTime);
	}
//	void OnBecameInvisible()
//	{
//	     Destroy(gameObject);
//	}
	void OnTriggerEnter2D(Collider2D collider)
	{
		if(!collider.GetComponent<Attacker>())
		{
			return;
		}
		else
		{ 
			GameObject obj=collider.gameObject;
			Health health=collider.GetComponent<Health>();
			health.dealdamage(damage);
			Destroy(gameObject);
			
		}
	}
}
