using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startScrpt : MonoBehaviour {//plays a cinematic before staring the game

	public bool beginCin = false;
	public bool clicked = false;

	public float abductTime = 2.5f;

	public SpriteRenderer ray;

	public AudioSource music;
	public AudioSource AS;
	public AudioSource AS2;
	public AudioClip ufo;
	public AudioClip huh;

	public TextMesh AstroFeeling;
	public float pause = 2f;

	public float nxtScene = 2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) && !clicked) {
			music.enabled = false;
			AS.PlayOneShot (ufo);
		}
		if (Input.GetKey (KeyCode.Space)) {
			beginCin = true;
			//UnityEngine.SceneManagement.SceneManager.LoadScene ();//Back to Menu
		}

		if (beginCin) {
			Vector3 shipFly = transform.position;
			if (shipFly.x <= 0.80f) {
				shipFly.x += 2;
			}
			if (shipFly.x >= 0.80f) {
				abductTime -= Time.deltaTime;
			}
			if (abductTime <= 0) {
				ray.enabled = false;
				shipFly.x += 2;
				pause -= Time.deltaTime;
			}
			transform.position = shipFly;

			if (pause <= -0.1) {
				AstroFeeling.fontSize = 200;
				AstroFeeling.fontStyle = FontStyle.Bold;

				Vector3 move = AstroFeeling.transform.position;
				move.y = 8.3f;
				transform.position = move;

				AstroFeeling.text = "!";

				//AS2.PlayOneShot (huh);
			}
			if (pause <= 0) {
				nxtScene -= Time.deltaTime;
			}

			if (nxtScene <= 0) {
				UnityEngine.SceneManagement.SceneManager.LoadScene ("GameScene");
			}


		}
	}
}
