using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {

	// Use this for initialization
	const string master_volume_key="master_volume";
	const string difficulty_key="difficulty";
	const string level_key="level_unlocked";
    public static void SetMasterVolume(float volume)
    {
		if(volume >=0f & volume <=1f)
		{
		PlayerPrefs.SetFloat(master_volume_key,volume);
		}
		else{
		 Debug.Log("invalid Voulme");
		}
     
    }
	public static float GetMasterVolume()
	{
		return PlayerPrefs.GetFloat(master_volume_key);
		
	}  
	public static void LevelUnlock(int level)
	{
		if(level <= Application.loadedLevel)
		{
			 PlayerPrefs.SetInt(level_key + level.ToString(),1);//use 1 for true
		}
		else
		{
			Debug.Log("invalid Voulme");
		}
	} 	
	public static bool IsLevelUnlocked(int level)
	{
		int levelvalue=PlayerPrefs.GetInt(level_key + level.ToString());
		 
		if(level <= Application.loadedLevel)
		{
			if(levelvalue==1)
			  return true;
			else
			  return false;
		}
		else{
			Debug.Log("invalid Voulme");
			return false;
		}
	}  
	public static void SetDifficulty(float diff)
	{
		if(diff >=1f & diff <=3f)
		{
			PlayerPrefs.SetFloat(difficulty_key,diff);
		}
		else{
			Debug.Log("invalid Difficulty");
		}
		
	}
	public static float GetDifficulty()
	{
		return PlayerPrefs.GetFloat(difficulty_key);
	}	
}
