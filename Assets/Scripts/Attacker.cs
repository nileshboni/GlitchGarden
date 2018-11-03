using UnityEngine;
using System.Collections;

public class Attacker : MonoBehaviour {

	// Use this for initialization
	[Range(0.5f,2f)]
	
	public float walkspeed;
	public float seeneveryseconds;
	private GameObject currentobject;
	public static float spawnset=1f;
	private Animator anim;
	void Start () 
	{
		Rigidbody2D myrigidbody= gameObject.AddComponent<Rigidbody2D>();
		myrigidbody.isKinematic=true;
		anim = gameObject.GetComponent<Animator>();
		SpawnControl();
		Debug.Log(seeneveryseconds);
	}
	
	// Update is called once per frame
	void Update () 
	{
		// this also works gameObject.rigidbody2D.velocity=new Vector2(-1 *walkspeed*Time.deltaTime,0f);
		transform.Translate(Vector3.left*walkspeed *Time.deltaTime);
		if(!currentobject)
		{
			anim.SetBool("isAttacking",false);
		}
	}
	void OnTriggerEnter2D()
	{
	   
	}
	public void SetSpeed(float speed)
	{
	   walkspeed=speed;	
	}
	public void StrikeDamage(float damage)
	{
	  if(currentobject)
	  {
	  Health health=currentobject.GetComponent<Health>();
	  if(health)
	  {
	      health.dealdamage(damage);
	  }
	  }
	  
	
	}
	public void  SpawnControl()
	{
	   float difficulty=PlayerPrefsManager.GetDifficulty();
	   if(difficulty==2f)
	   {
			spawnset=2;
		}
		if(difficulty==3f)
		{
			spawnset=3;
		}
	}
	public void attack(GameObject obj)
	{
		currentobject=obj;
	}
}
