using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Fade : MonoBehaviour {

	// Use this for initialization
	public float fadeintime;
	private Image fadeimage;
	private Color currentcolour=Color.black;
	void Start () 
	{
	   fadeimage=GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Time.timeSinceLevelLoad < fadeintime)
	    {
	      // Debug.Log("if");
	       float alphachange=Time.deltaTime/fadeintime;
			currentcolour.a-=alphachange;
	       fadeimage.color=currentcolour;
	       
	    }
	    else
	    {
			//Debug.Log("else");
	        gameObject.SetActive(false);
	    }
	}
}
