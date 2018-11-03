using UnityEngine;
using System.Collections;

public class Stone : MonoBehaviour {

	// Use this for initialization
	private Animator animator;
	void Start () {
		animator=GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerStay2D(Collider2D collider)
	{
		if(!collider.GetComponent<Attacker>())
		{
			return;
		}	
		animator.SetTrigger("underattack");	
	}
}
