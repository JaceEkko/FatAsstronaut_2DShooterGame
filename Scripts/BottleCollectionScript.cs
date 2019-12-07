using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottleCollectionScript : MonoBehaviour { //you have collected the beer keg, it ends the game



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 rot = transform.rotation.eulerAngles;
		rot.z += 3; 
		transform.rotation = Quaternion.Euler(rot);
	}

//	void OnTriggerEnter2D(Collider2D col){
//		if(col.gameObject.name == "Player"){
//			player.Beers.text = player.BeerCount.ToString ();
//			Destroy (gameObject);
//		}
//	}

	public void collect(PlayerController play){
//		play.BeerCount += 1;
//		play.Beers.text = play.BeerCount.ToString ();
//		play.beerSource.PlayOneShot (play.burp);
//		Destroy (gameObject);
	}
}
