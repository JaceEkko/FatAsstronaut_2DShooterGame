using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownScript : MonoBehaviour { //makes certain UFO move up and down on the screen

	public float upperBound = 10;
	public float lowerBound = -10;

	public bool upDone = false;
	public bool dwnDone = true;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		Vector3 vertMove = transform.position;

		if (vertMove.y <= upperBound && !upDone && dwnDone) {
			vertMove.y += 0.08f;
		} else {
			upDone = true;
			dwnDone = false;
		}

		if (vertMove.y >= lowerBound && upDone && !dwnDone) {
			vertMove.y -= 0.08f;
		} else {
			upDone = false;
			dwnDone = true;
		}

		transform.position = vertMove;
	}
}
