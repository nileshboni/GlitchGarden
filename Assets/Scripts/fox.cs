using UnityEngine;
using System.Collections;

public class fox : MonoBehaviour {

	// Use this for initialization
	private Animator anim;
	private Attacker atk;
	void Start () 
	{
	     anim=gameObject.GetComponent<Animator>();
	     atk=gameObject.GetComponent<Attacker>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D collider)
	{
	   if(!collider.GetComponent<Defender>())
	   {
	      return;
	   }
		if(collider.GetComponent<Stone>())
		{
			anim.SetTrigger("jumptrigger");
		}
		else
		{ 
			GameObject obj=collider.gameObject;
			anim.SetBool("isAttacking",true);
			atk.attack(obj);
		}
	}
}
