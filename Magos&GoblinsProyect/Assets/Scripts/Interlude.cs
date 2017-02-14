using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Interlude : MonoBehaviour {

	public Text introText;
	private bool changeText=false;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown(0)) {

			introText.text = "Once in the center of Svelge, you see some villagers being attacked by a pair of orcs. You decide to help them and fight the orcs.";
			Invoke ("nextPartOk", 0.5f);

			if (changeText) {

				GameObject partyManager = GameObject.Find ("PartyManager");
				if (partyManager != null) {
					DontDestroyOnLoad (partyManager);
				}
				SceneManager.LoadScene ("SecondFight");
			}
		}

	}

	void nextPartOk(){

		changeText = true;
	}

}