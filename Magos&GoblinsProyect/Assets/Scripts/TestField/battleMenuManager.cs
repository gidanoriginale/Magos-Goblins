using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class battleMenuManager : MonoBehaviour {
	
	public GameObject unitSelected;
	public GameObject menuPanel;
	public GameObject cellGrid;

	void Start () {
		GetComponent<Canvas> ().enabled = false;
	}

	void Update () {

		if (unitSelected != null && cellGrid.GetComponent<CellGrid>().CurrentPlayerNumber == unitSelected.GetComponent<Unit>().PlayerNumber) {
			GetComponent<Canvas> ().enabled = true;
			if (menuPanel != null) {
				menuPanel.GetComponent<RectTransform>().position = new Vector2 (unitSelected.transform.position.x, unitSelected.transform.position.y+0.8f);
			}
		} else {
			if (GetComponent<Canvas> ().enabled == true) {
				GetComponent<Canvas> ().enabled = false;
			}
		}
	}
}
