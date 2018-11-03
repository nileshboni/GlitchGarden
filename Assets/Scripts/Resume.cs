using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Resume : MonoBehaviour {

	// Use this for initialization
	public GameObject Pause;
	private Text mytext;
	void Start()
	{
	    mytext=gameObject.GetComponent<Text>();
	}
	void OnMouseDown()
	{
		gameObject.SetActive(false);
		Pause.SetActive(false);
		Time.timeScale=1;
	}
	void OnMouseOver()
	{
		mytext.color=Color.blue;
	}
	void OnMouseExit()
	{
		mytext.color=Color.yellow;
	}
}
