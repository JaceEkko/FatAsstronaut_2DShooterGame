using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSongScript : MonoBehaviour {

	public AutoScrollerScript ASS;

	public AudioSource AS;
	public AudioClip wave1;
	public bool start = false;
	public bool PlayOnceEnsurer = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		AS.PlayOneShot (wave1);
	}
}
