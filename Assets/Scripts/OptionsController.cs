using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class OptionsController : MonoBehaviour {

	// Use this for initialization
	public Slider VolumeSlider;
	public Slider DifficultySlider;
	public LevelManager lm;
	private MusicManager musicmanager;
	void Start () {
	 
		musicmanager=GameObject.Find("MusicManager").GetComponent<MusicManager>();
	   VolumeSlider.value=PlayerPrefsManager.GetMasterVolume();
		DifficultySlider.value=PlayerPrefsManager.GetDifficulty();
	}
	
	// Update is called once per frame
	void Update () 
	{
		musicmanager.ChangeVolume(VolumeSlider.value);
	}
	public void  SaveandExit()
	{
	    PlayerPrefsManager.SetMasterVolume(VolumeSlider.value);
	    PlayerPrefsManager.SetDifficulty(DifficultySlider.value);
	    lm.loadlevel("01Start");
	}
	public void SetDefaults()
	{
	      VolumeSlider.value=0.5f;
	      DifficultySlider.value=1f;
	}
}
