using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class selectionScreenController : MonoBehaviour {

	private GameObject[] menuOptions;
	public GameObject startingMenu;
	public GameObject newGame;
	public GameObject continueGame;
	public GameObject settings;
	public GameObject exitGame;
	public GameObject yesOption;
	public GameObject noOption;
	private int selectedIndex = 0;
	private Vector2 lastPosition;

	void Start() {
		menuOptions = new GameObject[4];
		menuOptions [0] = newGame;
		menuOptions[1] = continueGame;
		menuOptions[2] = settings;
		menuOptions[3] = exitGame;
	}

	void Update() {
		if (startingMenu.GetComponent<menuScript> ().quitMenu.enabled == false) {
			if (transform.localPosition.x != newGame.transform.localPosition.x -80 && transform.parent != newGame.transform.parent) {
				transform.parent = newGame.transform.parent;
				transform.localPosition = new Vector2 (lastPosition.x, lastPosition.y);;
			}
			if (Input.GetKeyDown (KeyCode.DownArrow)) {
				selectedIndex = menuSelection (menuOptions, selectedIndex, "down");
			}

			if (Input.GetKeyDown (KeyCode.UpArrow)) {
				selectedIndex = menuSelection (menuOptions, selectedIndex, "up");
			}

			if (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.Return)) {
				handleSelection ();
			}
		} else {
			if (transform.localPosition.y != yesOption.transform.localPosition.y && transform.parent != yesOption.transform.parent) {
				lastPosition = new Vector2(transform.localPosition.x, transform.localPosition.y);
				transform.parent = yesOption.transform.parent;
				transform.localPosition = new Vector2 (noOption.transform.localPosition.x -1, noOption.transform.localPosition.y);
			}
			if (Input.GetKeyDown (KeyCode.RightArrow)) {
				transform.localPosition = new Vector2 (noOption.transform.localPosition.x -1, noOption.transform.localPosition.y);
			}
			if (Input.GetKeyDown (KeyCode.LeftArrow)) {
				transform.localPosition = new Vector2 (yesOption.transform.localPosition.x -1, yesOption.transform.localPosition.y);
			}
			if (Input.GetKeyDown (KeyCode.Space) || Input.GetKeyDown (KeyCode.Return)) {
				if (transform.localPosition.x == yesOption.transform.localPosition.x - 1) {
					startingMenu.GetComponent<menuScript> ().ExitGame();
				} else {
					startingMenu.GetComponent<menuScript> ().NoPress();
				}
			}
		}
	}

	private int menuSelection (GameObject[] menuItems, int selectedItem, string direction) {

		if (direction == "up") {
			if (selectedItem == 0) {
				selectedItem = menuItems.Length-1;
			} else {
				selectedItem -= 1;
			}
		}

		if (direction == "down") {
			if (selectedItem == menuItems.Length-1) {
				selectedItem = 0;
			} else {
				selectedItem += 1;
			}
		}

		transform.localPosition = new Vector2 (menuItems[selectedItem].transform.localPosition.x -80, menuItems[selectedItem].transform.localPosition.y);

		return selectedItem;
	}

	void handleSelection() {
		GUI.FocusControl (menuOptions[selectedIndex].name);
		switch (menuOptions[selectedIndex].name) {
		case "New Game Text":
			startingMenu.GetComponent<menuScript> ().StartGame ();
			break;
		case "Continue Text":
			//Loading Screen
			break;
		case "Settings Text":
			//Show settings
			break;
		case "Exit Text":
			startingMenu.GetComponent<menuScript> ().ExitPress ();
			break;
		default:
			break;
		}
		Debug.Log("Selected name: " + menuOptions[selectedIndex].name + " / id: " +selectedIndex);
	}
}
