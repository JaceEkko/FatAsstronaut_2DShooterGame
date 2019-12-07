using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abductScript : MonoBehaviour { //during cinematic makes it so the keg disappears when UFO flys over it

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "Ray") {
			Destroy (gameObject);
		}
	}
}
