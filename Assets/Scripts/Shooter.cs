using UnityEngine;
using System.Collections;

public class Shooter : MonoBehaviour {

	// Use this for initialization
	public GameObject projectile,gun;
	private GameObject parentprojectile;
	private Animator animator;
	public Spawnner mylane;
    void Start()
    {
		parentprojectile=GameObject.Find ("Projectiles");
		animator= GameObject.FindObjectOfType<Animator>();
		if(!parentprojectile)
		{
			parentprojectile = new GameObject("Projectiles");
		}
		setlane ();
    }
    void Update()
    {
        if(targetsamelane())
        {
			animator.SetBool("isAttacking",true);
        }
        else
        {
			animator.SetBool("isAttacking",false);
        }
    }
    private void Fire()
    {
		GameObject newProjectile= Instantiate(projectile) as GameObject;
		newProjectile.transform.parent=parentprojectile.transform;
		newProjectile.transform.position=gun.transform.position;
    }
    bool targetsamelane()
    {
//        foreach (Transform child in mylane)
//        {
//            
//        }
        if(mylane.transform.childCount<=0)
        {
        return false;
        }
        else
        {
          foreach(Transform child in mylane.transform)
          {
        	if(child.transform.position.x>this.transform.position.x)
        	{
        	     return true;
        	}   
        	
          }    
			return false;       
        }
    }
    void setlane()
    {
		Spawnner[] spawnner= GameObject.FindObjectsOfType<Spawnner>();
		foreach(Spawnner  lane in spawnner)
		{
		   if(lane.transform.position.y==this.transform.position.y)
		   {
				mylane=lane;
				return;
		   }
		}
    }
}
