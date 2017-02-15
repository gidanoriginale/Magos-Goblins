using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Intro2Manager : MonoBehaviour {

	private bool changeText=false;
	public Text introText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown(0)) {

			introText.text = "The mission is about fighting a goblin invasion that is reaching the frontier town Svelge.";
			Invoke ("nextPartOk", 0.5f);

			if (changeText) {

				GameObject partyManager = GameObject.Find ("PartyManager");
				if (partyManager != null) {
					DontDestroyOnLoad (partyManager);
				}
				SceneManager.LoadScene ("Introduction3");
			}
		}

	}

	void nextPartOk(){

		changeText = true;
	}

}