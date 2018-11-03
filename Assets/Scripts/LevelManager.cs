using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public float autoloadllevelafter=5f;
	public bool autoload;
	
	void Start()
	{
		if(autoload)
		{
		Invoke("LoadNextLevel",autoloadllevelafter);
		}
	}
	public void loadlevel(string name)
	{
	   Debug.Log("level");
	   Application.LoadLevel(name);
	}
	public void quitlevel()
	{
		Debug.Log("level");
		Application.Quit();
	}
	public void LoadNextLevel()
	{

	  Application.LoadLevel(Application.loadedLevel +1);
	}

}  
