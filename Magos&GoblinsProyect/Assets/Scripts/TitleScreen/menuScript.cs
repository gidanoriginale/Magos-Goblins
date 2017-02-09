using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class menuScript : MonoBehaviour {

	public Canvas quitMenu;
	public Button startText;
	public Button continueText;
	public Button settingsText;
	public Button exitText;

	// Use this for initialization
	void Start () {
		quitMenu = quitMenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		continueText = continueText.GetComponent<Button>();
		settingsText = settingsText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button>();
		quitMenu.enabled = false;
	}

	public void ExitPress() {
		quitMenu.enabled = true;
		startText.enabled = false;
		continueText.enabled = false;
		settingsText.enabled = false;
		exitText.enabled = false;
	}

	public void NoPress() {
		quitMenu.enabled = false;
		startText.enabled = true;
		continueText.enabled = true;
		settingsText.enabled = true;
		exitText.enabled = true;
	}

	public void StartLevel(){
		SceneManager.LoadScene ("TestField");
	}

	public void ExitGame() {
		Application.Quit ();
	}

}
