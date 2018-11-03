using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

  private LevelManager levelmanager;
  void Start()
  {
		levelmanager=GameObject.FindObjectOfType<LevelManager>();
  }
  void OnTriggerEnter2D(Collider2D collider)
  {
     levelmanager.loadlevel("03bLoose");
  }
}
