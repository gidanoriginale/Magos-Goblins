using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Intro2Manager : MonoBehaviour {

	public Text introText;
	private bool changeText=false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {

			introText.text = "The mission consist to fight the goblin invasion in the frontier town Svelge. ";
			Invoke ("nextPartOk", 1);

			if (changeText) {

				GameObject partyManager = GameObject.Find ("PartyManager");
				if (partyManager != null) {
					DontDestroyOnLoad (partyManager);
				}
				SceneManager.LoadScene ("TestField");
			}
		}
	}

	void nextPartOk(){

		changeText = true;
	}
}
