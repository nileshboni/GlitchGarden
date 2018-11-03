using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Button : MonoBehaviour {

	// Use this for initialization
	public GameObject defenderprefab;
	private Text costtext;
	private Button[] buttons;
	public static  GameObject SelectedDefender;
	void Start () {
		buttons=GameObject.FindObjectsOfType<Button>();
		costtext=gameObject.GetComponentInChildren<Text>();
		costtext.text=defenderprefab.GetComponent<Defender>().cost.ToString();
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown()
	{
		foreach (Button button in buttons)
		{
			button.GetComponent<SpriteRenderer>().color=Color.black;
		}
	   GetComponent<SpriteRenderer>().color=Color.white;
		SelectedDefender=defenderprefab;
	}
}
