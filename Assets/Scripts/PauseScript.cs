using UnityEngine;
using System.Collections;

public class PauseScript : MonoBehaviour {

	// Use this for initialization
	public GameObject resume;
	void Start () {
	  resume=GameObject.Find("Resume");
	}
    public void Pause()
    {
      gameObject.SetActive(true);
      resume.SetActive(true);
      Time.timeScale=0;
      
    }
//    public void Unpause()
//    {
//		gameObject.SetActive(false);
//		resume.SetActive(false);
//		Time.timeScale=1;
//    }
}
