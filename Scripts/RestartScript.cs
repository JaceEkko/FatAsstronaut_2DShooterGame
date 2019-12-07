using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartScript : MonoBehaviour { //brings up back to the titleScene

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) {
			UnityEngine.SceneManagement.SceneManager.LoadScene ("TitleScene");//Back to Menu
		}
	}
}
