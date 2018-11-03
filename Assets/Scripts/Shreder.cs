using UnityEngine;
using System.Collections;

public class Shreder : MonoBehaviour {

	// Use this for initialization
    void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(collider.gameObject);
    }
}
