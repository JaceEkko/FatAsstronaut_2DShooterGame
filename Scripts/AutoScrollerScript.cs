using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoScrollerScript : MonoBehaviour { //camera moves on its own through the level, the player must follow it

	public float getSet = 3;

	public AudioSource AS;
	public AudioClip beep;

	private bool beep1 = false;
	private bool beep2 = false;
	private bool beep3 = false;

	public TextMesh beerCommand;

	public int wave = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		getSet -= Time.deltaTime;

		if (getSet <= 2.9f && !beep1) { //beep countdown
			AS.PlayOneShot(beep);
			beep1 = true;
		}
		if (getSet <= 1.9f && !beep2) { //beep countdown
			AS.PlayOneShot(beep);
			beep2 = true;
		}
		if (getSet <= 0.9f && !beep3) { //beep countdown
			AS.PlayOneShot(beep);
			beep3 = true;
		}

		Vector3 Go = transform.position;
		if(getSet <= 0 && Go.x >= -22.30f){
			beerCommand.text = "";
			Go.x += 0.05f;

		}
		transform.position = Go;
	}
}
