using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameTimer : MonoBehaviour {

	// Use this for initialization
	public int starttime;
	private Slider slider;
	private AudioSource audiosource;
	private bool isendoflevel=false;
	private LevelManager lm;
	public AudioClip win;
	private GameObject Winlabel;
	//private GameObject[] DestroyObjects;
	void Start () {
		slider=GetComponent<Slider>();
		audiosource=GetComponent<AudioSource>();
		lm=GameObject.FindObjectOfType<LevelManager>();
		Winlabel=GameObject.Find("WinLabel");
		if(!Winlabel)
		{
		  Debug.Log("Win Label not found");
		}
		else
		{
		   Winlabel.SetActive(false);
		}
		//timeleft=starttime;
	}
	
	// Update is called once per frame
	void Update () 
	{
	     //timeleft=timeleft-1;
		slider.value=Time.timeSinceLevelLoad/starttime;
		if(Time.timeSinceLevelLoad>starttime && !isendoflevel)
	     {
			DestroyAll();
			audiosource.Play();
			Winlabel.SetActive(true);
			Invoke("LoadNextLevel",audiosource.clip.length);
			isendoflevel=true;
	     }
	}
	void LoadNextLevel()
	{
	   lm.LoadNextLevel();
	}
	void DestroyAll()
	{
		GameObject[] DestroyObjects=GameObject.FindGameObjectsWithTag("DestroyOnWin");
	   foreach(GameObject obj in DestroyObjects)
	   {
	      Destroy(obj);
	   }
	}
}
