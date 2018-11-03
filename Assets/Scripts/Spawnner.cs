using UnityEngine;
using System.Collections;

public class Spawnner : MonoBehaviour {

	// Use this for initialization
	public GameObject[] attackerarray;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		foreach (GameObject thisattacker in attackerarray)
	  {
			if(isTimeToSpawn(thisattacker))
			{
				Spawn (thisattacker);
			}
	  }
	}
	bool isTimeToSpawn(GameObject mygameobject)
	{
		Attacker attacker= mygameobject.GetComponent<Attacker>();
		float meanspawndelay= attacker.seeneveryseconds;
		float  spwanspersecond=(Attacker.spawnset)/meanspawndelay;
		if(Time.deltaTime > meanspawndelay)
		{
		    Debug.LogWarning("framerate less");
		}
		float threshold=Time.deltaTime * spwanspersecond;
		if(Random.value< threshold)
		{
		   return true;
		}
		else{
		  return false;
		}
	}
	void Spawn(GameObject  mygameobject)
	{
		GameObject myattacker= Instantiate(mygameobject) as GameObject;
		myattacker.transform.parent=this.transform;
		myattacker.transform.position=this.transform.position;
	}
}
