using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingScript : MonoBehaviour { //UFO shoots back at player, smae sort of code as the AImFireScript

	public AudioSource AS;
	public AudioClip shoot;

	public GameObject BulletPrefab;

	public float BeforeShoot = 0.5f;

	public PlayerController player;

	public GameObject cameraObj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		BeforeShoot -= Time.deltaTime;
		if (BeforeShoot <= 0) {
			GameObject ast = Instantiate (BulletPrefab);
			Vector3 newGPos = ast.transform.position;
			newGPos.x = transform.position.x - 2.5f;
			newGPos.y = transform.position.y;
			ast.transform.position = newGPos;

			AS.PlayOneShot (shoot);

			BeforeShoot = 2;

			Rigidbody2D rd2 = ast.GetComponent<Rigidbody2D> ();
			rd2.velocity = new Vector3 (-10, 0);

			//			Vector3 mworldpos = Camera.main.ScreenToWorldPoint (player.transform.position);
			//
			//			Vector3 toPlayer = mworldpos - transform.position;
			//
			//			toPlayer.Normalize();
			//
			//			rd2.velocity = new Vector3 (10* -toPlayer.x, 10 * toPlayer.y);
		}

	}

	void OnTriggerEnter2D(Collider2D col){
//		if (BeforeShoot <= 0) {
//			GameObject ast = Instantiate (BulletPrefab);
//			Vector3 newGPos = ast.transform.position;
//			newGPos.x = transform.position.x - 2.5f;
//			newGPos.y = transform.position.y;
//			ast.transform.position = newGPos;
//
//			AS.PlayOneShot (shoot);
//
//			BeforeShoot = 2;
//
//			Rigidbody2D rd2 = ast.GetComponent<Rigidbody2D> ();
//			rd2.velocity = new Vector3 (-10, 0);
//
////			Vector3 mworldpos = Camera.main.ScreenToWorldPoint (player.transform.position);
////
////			Vector3 toPlayer = mworldpos - transform.position;
////
////			toPlayer.Normalize();
////
////			rd2.velocity = new Vector3 (10* -toPlayer.x, 10 * toPlayer.y);
//		}
	}
}
