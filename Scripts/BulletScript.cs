using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour { //despawns bullets after a period of time

	public float timeDespawn = 6;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timeDespawn -= Time.deltaTime;

		if (timeDespawn <= 0) {
			Destroy (gameObject);
		}
	}

	void onTriggerEnter2D(Collider2D col){ //this function takes a collider, onCollisionEnter2D takes in a collision
		GettingHitScript ghs = col.gameObject.GetComponent<GettingHitScript>();
		Debug.Log (ghs.gameObject.name);
		if (ghs != null) {
			//ghs.Hit (this);
		}
	}
}
