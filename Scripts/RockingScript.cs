using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockingScript : MonoBehaviour {//makes an object look like its rocking, or rotation depending on the rockorroll boolean

	public float rock = 16.3f;
	public float roll = 0.1f;

	public float upperBound = 6.72f;
	public float lowerBound = 43.4f;

	public bool upDone = false;
	public bool dwnDone = true;

	public bool rockORRoll = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 rot = transform.rotation.eulerAngles;

		if (rockORRoll) {
			if (rot.z >= upperBound && !upDone && dwnDone) {
				rot.z -= 0.3f;
			} else {
				upDone = true;
				dwnDone = false;
			}

			if (rot.z <= lowerBound && upDone && !dwnDone) {
				rot.z += 0.3f;
			} else {
				upDone = false;
				dwnDone = true;
			}
		} else {
			rot.z += roll;
		}

		transform.rotation = Quaternion.Euler(rot);
	}
}
