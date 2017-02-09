using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class selectionScreenController : MonoBehaviour {

	private GameObject[] menuOptions;
	public GameObject newGame;
	public GameObject continueGame;
	public GameObject settings;
	public GameObject exitGame;
	private int selectedIndex = 0;

	void Start() {
		menuOptions = new GameObject[4];
		menuOptions [0] = newGame;
		menuOptions[1] = continueGame;
		menuOptions[2] = settings;
		menuOptions[3] = exitGame;
	}

	void Update() {
		if (Input.GetKeyDown(KeyCode.DownArrow)) {
			selectedIndex = menuSelection(menuOptions, selectedIndex, "down");
		}

		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			selectedIndex = menuSelection(menuOptions, selectedIndex, "up");
		}

		if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return)) {
			handleSelection();
		}
		//Debug.Log (selectedIndex);
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
		//GUI.FocusControl (menuOptions[selectedIndex]);
		Debug.Log("Selected name: " + menuOptions[selectedIndex].name + " / id: " +selectedIndex);
	}
//
//	function OnGUI ()
//	{
//		GUI.SetNextControlName ("Tutorial");
//		if (GUI.Button(Rect(10,70,170,30), "Button 1 (tutorial,id:0)")) {
//			selectedIndex = 0;
//			handleSelection();
//		}
//
//		GUI.SetNextControlName ("Play");
//		if (GUI.Button(Rect(10,100,170,30), "Button 2 (play, id:1)")) {
//			selectedIndex = 1;
//			handleSelection();
//		}
//
//		GUI.SetNextControlName ("High Scores");
//		if (GUI.Button(Rect(10,130,170,30), "Button 3 (high scores, id:2)")) {
//			selectedIndex = 2;
//			handleSelection();
//		}
//
//		GUI.SetNextControlName ("Exit");
//		if (GUI.Button(Rect(10,160,170,30), "Button 4 (exit, id:3)")) {
//			selectedIndex = 3;
//			handleSelection();
//		}
//
//		GUI.FocusControl (menuOptions[selectedIndex]);
//	}
}
