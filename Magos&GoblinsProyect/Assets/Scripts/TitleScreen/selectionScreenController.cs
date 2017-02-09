using UnityEngine;
using System.Collections;

public class selectionScreenController : MonoBehaviour {

	new Vector3 posicionInicial;
	new Vector3 posicionFinal;
	public GameObject startingMenuObject;
	public GameObject quitMenuOptions;

	void Start () {
		posicionInicial = new Vector3(this.transform.localPosition.x, startingMenuObject.GetComponent<menuScript> ().startText.transform.localPosition.y, this.transform.localPosition.z);
		posicionFinal = new Vector3 (this.transform.localPosition.x, startingMenuObject.GetComponent<menuScript> ().exitText.transform.localPosition.y, this.transform.localPosition.z);
	}
		
	void Update () {

		Vector3 posicionActual = new Vector3 (transform.localPosition.x, transform.localPosition.y, transform.localPosition.z);
		Debug.Log (posicionActual.y == quitMenuOptions.transform.localPosition.y);
		//If the quitMenu from startingMenu is DISABLED
		if (startingMenuObject.GetComponent<menuScript> ().quitMenu.enabled == false) {
			if (posicionActual.y == quitMenuOptions.transform.localPosition.y) {
				this.transform.parent = startingMenuObject.GetComponent<menuScript>().startText.transform.parent;
				//transform.localPosition = new Vector3 (-150, yesOption.transform.localPosition.y, yesOption.transform.localPosition.z);
			}
			//Moves the cursor down. If player tries to go further down when there are no
			//more options, it'll go back to the starting position (posicionInicial)
			if (Input.GetKeyDown (KeyCode.DownArrow)) {			
				Vector3 nuevaPosicion = new Vector3 (this.transform.localPosition.x, this.transform.position.y - 30, this.transform.localPosition.z);
				if (this.GetComponent<RectTransform> ().localPosition.y > posicionFinal.y) {
					this.transform.localPosition = new Vector3 (this.transform.localPosition.x, this.transform.localPosition.y - 30, this.transform.localPosition.z);
				} else {
					this.transform.localPosition = posicionInicial;
				}
			}

			//Moves the cursor up. If player tries to go further up when there are no
			//more options, it'll go to the last available option (posicionFinal)
			if (Input.GetKeyDown (KeyCode.UpArrow)) {
				Vector3 nuevaPosicion = new Vector3 (this.transform.localPosition.x, this.transform.localPosition.y + 30, this.transform.localPosition.z);
				if (this.GetComponent<RectTransform> ().localPosition.y < posicionInicial.y) {
					this.transform.localPosition = nuevaPosicion;
				} else {
					this.transform.localPosition = posicionFinal;
				}
			}
		//If the quitMenu from startingMenu is ENABLED
		} else {
			if (posicionActual.x == -110) {
				this.transform.parent = quitMenuOptions.transform.parent;
				transform.localPosition = new Vector3 (quitMenuOptions.transform.localPosition.x -50, quitMenuOptions.transform.localPosition.y, quitMenuOptions.transform.localPosition.z);
			}
		}

		//Input Intro or Spacebar -> Depending on the position of the cursor, 
		//it'll call one function or another from the GameObject Starting Menu.
		if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return)) {
			//If the quitMenu from startingMenu is disabled
			if (startingMenuObject.GetComponent<menuScript>().quitMenu.enabled == false) {
				if (transform.localPosition.y == startingMenuObject.GetComponent<menuScript>().startText.transform.localPosition.y) {
					startingMenuObject.GetComponent<menuScript> ().StartGame ();
				}

				if (transform.localPosition.y == startingMenuObject.GetComponent<menuScript>().continueText.transform.localPosition.y) {
					//Function to Load Level
				}

				if (transform.localPosition.y == startingMenuObject.GetComponent<menuScript>().settingsText.transform.localPosition.y) {
					//Function to change game settings
				}

				if (transform.localPosition.y == startingMenuObject.GetComponent<menuScript>().exitText.transform.localPosition.y) {
					startingMenuObject.GetComponent<menuScript> ().ExitPress ();
				}
			}
		}
	}
}
