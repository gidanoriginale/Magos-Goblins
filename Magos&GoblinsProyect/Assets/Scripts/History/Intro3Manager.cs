using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Intro3Manager : MonoBehaviour {

	public Text introText;
	private bool changeText=false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown(0) || Input.GetKeyDown (KeyCode.Return)) {

			introText.text = "Ten of them pounce to you all!";
			Invoke ("nextPartOk", 0.5f);

			if (changeText) {

				GameObject partyManager = GameObject.Find ("PartyManager");
				if (partyManager != null) {
					DontDestroyOnLoad (partyManager);
				}
				SceneManager.LoadScene ("FirstFight");
			}
		}
	}

	void nextPartOk(){

		changeText = true;
	}
}
