using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateScript : MonoBehaviour { //used to make the astro tilt depending on what direction he is flying in
	
	public bool rotR = false;
	public bool rotL = false;

	public Quaternion left;
	public Quaternion right;

	public SpriteRenderer typeofflame;
	public Sprite small;
	public Sprite large;

	// Use this for initialization
	void Start () {
		left.z = 350; //used to be 17
		right.z = 300;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 rot = transform.rotation.eulerAngles;

//		Debug.Log ("rot "+rot.z);
//		Debug.Log ("left "+left.z);
//		Debug.Log ("right "+right.z);

		if (Input.GetKey (KeyCode.RightArrow)) {
			if (rot.z >= right.z) {
				rot.z -= 4; 
				typeofflame.sprite = small;
				//rotR = true;
		    } else {
				//rotR = false;
				typeofflame.sprite = large;
			}
		}
		else if (Input.GetKey (KeyCode.LeftArrow)) {
			if (rot.z <= left.z) {
				//rot.z = -rot.z;
				typeofflame.sprite = small;
				rot.z += 4; 
				//rotL = true;
			} else {
//				rotL = false;
				typeofflame.sprite = large;
			}
		}

		if (rotR) {
			rot.z = rot.z - 4; 
		}
		if (rotL) {
			rot.z = rot.z + 4;
		}

		transform.rotation = Quaternion.Euler(rot);
	}
}
