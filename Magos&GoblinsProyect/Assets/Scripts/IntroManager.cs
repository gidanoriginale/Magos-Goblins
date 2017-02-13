using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroManager : MonoBehaviour {

	public Text introText;
	private bool changeText=false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {
		
			introText.text = "Those monsters are commanded by the Cirwyr's wizards of the court who got exiled because the king feared their magic. Now, they search for vengeance against the Kingdom who took away everything that belonged to them.";
			Invoke ("nextPartOk", 1);

			if (changeText) {

				GameObject partyManager = GameObject.Find ("PartyManager");
				if (partyManager != null) {
					DontDestroyOnLoad (partyManager);
				}
				SceneManager.LoadScene ("Introduction2");
			}
		}
	
	}

	void nextPartOk(){

		changeText = true;
	}

}
