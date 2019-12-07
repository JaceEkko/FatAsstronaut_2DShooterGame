using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GettingHitScript : MonoBehaviour {

	public PlayerController player;

	public SpriteRenderer sr;
	public Sprite explode;

	public int countTillDeath = 10;
	public float deathTimer = 0.5f;

	public bool deadHit = false;

	public AudioSource AS;
	public AudioClip hit;
	public AudioClip dead;

	public GameObject TheBs;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//sr.color = new Color (255,0,0);
		if(countTillDeath == 0){/*AS.PlayOneShot (dead);*/}
		if(countTillDeath <= 0){
			deadHit = true;
			sr.sprite = explode;
			AS.PlayOneShot (dead);
			deathTimer -= Time.deltaTime;
			if (deathTimer <= 0) {
				//AS.PlayOneShot (dead);
				player.KillCount += 1;
				player.Kills.text = player.KillCount.ToString ();

				Destroy (gameObject);
			}
		}

	}


	void OnTriggerEnter2D(Collider2D col){ 
		if(countTillDeath > 0 && col.gameObject.name == "PlayBullet(Clone)"){ //player shoots the UFO
			sr.color = new Color (255, 0, 0);
			AS.PlayOneShot (hit);
			countTillDeath -= 1;
		}

	}
//
	void OnTriggerExit2D(Collider2D col){ //turns UFO color back to normal
		if (col.gameObject.name == "PlayBullet(Clone)") {
			sr.color = new Color (255, 255, 255);
		}
	}

}
