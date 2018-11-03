using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StarDisplay : MonoBehaviour {

	// Use this for initialization
	private Text mytext;
	private int stars=200;
	public enum Status {SUCCESS,FAILURE};
	void Start () 
	{
		mytext=gameObject.GetComponent<Text>();
		mytext.text=stars.ToString();
	}
	
	public void Addstars(int points)
	{
	   stars= stars + points;
	   mytext.text=stars.ToString();
	}
	public Status Usestars(int points)
	{
		if(points<=stars)
		{
			stars= stars - points;
			mytext.text=stars.ToString();
			return Status.SUCCESS;
		}
			return Status.FAILURE;
				
	}	
}
