using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using System.Linq;
using System;

public class battleMenuManager : MonoBehaviour {
	
	public GameObject unitSelected;
	public GameObject unitClicked;
	public GameObject menuPanel;
	public Text moveText;
	public Text attackText;
	public GameObject cellGrid;
	public bool unitIsAttacking;

	void Start () {
		GetComponent<Canvas> ().enabled = false;
	}

	void Update () {
		if (GetComponent<Canvas> ().enabled && cellGrid.activeSelf == true) {
			cellGrid.SetActive (false);
		} else {
			if (!GetComponent<Canvas> ().enabled && cellGrid.activeSelf == false) {
				cellGrid.SetActive (true);
			}
		}

		if (unitSelected != null && cellGrid.GetComponent<CellGrid>().CurrentPlayerNumber == unitSelected.GetComponent<Unit>().PlayerNumber && 
			!unitSelected.GetComponent<Unit> ().unitAttack && !unitSelected.GetComponent<Unit>().moveOn && (unitSelected.GetComponent<Unit>().MovementPoints != 0 || unitSelected.GetComponent<Unit>().ActionPoints != 0)) {
			GetComponent<Canvas> ().enabled = true;
			if (menuPanel != null) {
				menuPanel.GetComponent<RectTransform>().position = new Vector2 (unitSelected.transform.position.x, unitSelected.transform.position.y+0.4f);
			}
		} else {
			if (GetComponent<Canvas> ().enabled == true) {
				GetComponent<Canvas> ().enabled = false;
			}
		}
	}

	public void UnitMoving() {
		if (unitSelected.GetComponent<Unit> ().MovementPoints != 0) {
			unitSelected.GetComponent<Unit> ().moveUnit ();
			GetComponent<Canvas> ().enabled = false;
		}
	}

	public void UnitAttacking () {
		if (unitSelected.GetComponent<Unit>().ActionPoints != 0) {
			unitSelected.GetComponent<Unit> ().UnitAttack();
			GetComponent<Canvas> ().enabled = false;
		}
	}

	public void onExitClick() {
		GetComponent<Canvas> ().enabled = false;
		unitSelected = null;
	}
}
