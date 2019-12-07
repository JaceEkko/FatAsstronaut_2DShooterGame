using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helmetScript : MonoBehaviour { //game over script makes any object rotate like its floating

	public float spin = 0.06f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 rot = transform.rotation.eulerAngles;
		rot.z += spin; 
		transform.rotation = Quaternion.Euler(rot);
	}
}
