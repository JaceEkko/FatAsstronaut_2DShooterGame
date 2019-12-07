using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public GameObject TheBeer;
	public bool collected = false;

	public GameObject cameraObj;

	public GameObject thePlay;

	public Rigidbody2D rd;

	public SpriteRenderer srPlay;

	public int speed = 800;

	public float RedCount = 0.5f;
	public bool red = false;

	public TextMesh LifeLeft;
	public TextMesh Kills;
	public TextMesh Beers;

	public int Life = 100;
	public int BeerCount = 0;
	public int KillCount = 0;

	public AudioSource AS;
	public AudioClip hurt;

	public AudioSource beerSource;
	public AudioClip burp;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		
		//move player
		if (Input.GetKey (KeyCode.UpArrow)) {
			rd.AddForce (new Vector3 (0, speed));
		}
		else if (Input.GetKey (KeyCode.RightArrow)) {
			rd.AddForce (new Vector3 (speed, 0));
		}
		else if (Input.GetKey (KeyCode.LeftArrow)) {
			rd.AddForce (new Vector3 (-speed, 0));
		}
		else if (Input.GetKey (KeyCode.DownArrow)) {
			rd.AddForce (new Vector3 (0, -speed));
		}
		else{
			rd.AddForce (new Vector3 (0, 0));
		}

		//player has been hit by enemy
		if (red == true) {
			srPlay.color = new Color (255, 0, 0);
			RedCount -= Time.deltaTime;
		}
		if (RedCount <= 0) {
			red = false;
			srPlay.color = new Color (255, 255, 255);
			RedCount = 0.5f;
		}

		//your player is dead
		if (Life <= 0) {
			UnityEngine.SceneManagement.SceneManager.LoadScene ("GameOverScene"); //game over
		}

	}

	void OnTriggerEnter2D(Collider2D col){
		if (col.gameObject.name == "enemyUFO") { //hit by a UFO
			Life -= 10;
			LifeLeft.text = Life.ToString ();
			rd.AddForce (new Vector3 (-100, 0));
			AS.PlayOneShot (hurt);
			red = true;
		}
		if (col.gameObject.name == "EnBullet(Clone)") { //hit by bullet
			Life -= 5;
			LifeLeft.text = Life.ToString ();
			//rd.AddForce (new Vector3 (-100, 0));
			AS.PlayOneShot (hurt);
			red = true;
		}

		if (col.gameObject.name == "GameEnd") { //got the beer keg
			UnityEngine.SceneManagement.SceneManager.LoadScene("EndScene"); //end game
		}
	}
	void OnTriggerExit2D(Collider2D col){//pushes the player out of UFO after being hit by it
		if (col.gameObject.name == "enemyUFO") {
			rd.AddForce (new Vector3 (0, 0));
			//srPlay.color = new Color (255,255,255);
		}
	}
}
