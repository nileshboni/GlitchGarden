using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	// Use this for initialization
	public AudioClip[] levelMusicChange;
	private AudioSource audiosource;
	void Awake()
	{
	  DontDestroyOnLoad(gameObject);
	}
	void Start () 
	{
	       audiosource=gameObject.GetComponent<AudioSource>();
		   float ms=PlayerPrefsManager.GetMasterVolume();
		   ChangeVolume(ms);
			Debug.Log("if");
			
	}
	
	// Update is called once per frame
	void OnLevelWasLoaded (int level)
	{
		AudioClip thislevelmusic=levelMusicChange[level];
		if(thislevelmusic)
		{
		  audiosource.clip=thislevelmusic;
		  audiosource.loop=true;
		  audiosource.Play();
		
		}
	}
	public void ChangeVolume(float volume)
	{
	      audiosource.volume=volume;
	}
}
