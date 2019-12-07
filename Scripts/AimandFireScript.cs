using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimandFireScript : MonoBehaviour { //aim and fire bullets from players gun

	public GameObject gun;

	public GameObject cameraObj;

	public GameObject BulletPrefab;

	public AudioSource AS;
	public AudioClip AC;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
//		Vector3 mworldposAim = Camera.main.ScreenToWorldPoint (Input.mousePosition);
//
//		Rigidbody2D rd = gun.GetComponent<Rigidbody2D> ();
//
//		Vector3 toMouseAim = mworldposAim - transform.rotation.eulerAngles;
//
//		rd.rotation = new Vector3 (Quaternion.Euler(toMouseAim), Quaternion.Euler(toMouseAim));


		if (Input.GetMouseButtonDown (0)) {

			AS.PlayOneShot (AC);
			//spawn bullets
			GameObject ast = Instantiate (BulletPrefab);
			Vector3 newGPos = ast.transform.position;
			newGPos.x = transform.position.x + 2;
			newGPos.y = transform.position.y;
			ast.transform.position = newGPos;

			Rigidbody2D rd2 = ast.GetComponent<Rigidbody2D> ();
			rd2.velocity = new Vector3 (30, 0);

			//aim bullets
			Vector3 mworldpos = Camera.main.ScreenToWorldPoint (Input.mousePosition);

			Vector3 toMouse = mworldpos - transform.position;

			toMouse.Normalize();

			rd2.velocity = new Vector3 (40 * toMouse.x, 40 * toMouse.y);
		}
	}
}
