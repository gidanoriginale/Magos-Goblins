using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class menuScript : MonoBehaviour{

	public Canvas quitMenu;
	public Button startText;
	public Button continueText;
	public Button settingsText;
	public Button exitText;
	public Image goblinCursor;

	// Use this for initialization
	void Start () {
		quitMenu = quitMenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		continueText = continueText.GetComponent<Button>();
		settingsText = settingsText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button>();
		goblinCursor = goblinCursor.GetComponent<Image>();
		quitMenu.enabled = false;
	}

	void Update() {

	}

	public void ExitPress() {
		quitMenu.enabled = true;
		startText.enabled = false;
		continueText.enabled = false;
		settingsText.enabled = false;
		exitText.enabled = false;
//		goblinCursor.enabled = false;
	}

	public void NoPress() {
		quitMenu.enabled = false;
		startText.enabled = true;
		continueText.enabled = true;
		settingsText.enabled = true;
		exitText.enabled = true;
//		goblinCursor.enabled = true;
	}

	public void StartGame(){
		SceneManager.LoadScene ("PartySelection");
	}

	public void ExitGame() {
		Application.Quit ();
	}

}
