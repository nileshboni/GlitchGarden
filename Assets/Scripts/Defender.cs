using UnityEngine;

using System.Collections;

public class Defender : MonoBehaviour {

	// Use this for initialization
	public int cost=10;
	private StarDisplay stardisplay;
    void Start()
    {
		stardisplay=GameObject.FindObjectOfType<StarDisplay>();
    }
    public void AddStars(int points)
    {
       stardisplay.Addstars(points);
    }
	void OnTriggerEnter2D()
	{
		//Debug.Log(name+"trigger");
	}	
}
