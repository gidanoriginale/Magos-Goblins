using UnityEngine;
using System.Collections;

public class RoguePanel: MonoBehaviour {

	public bool rogueInfo =false;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseEnter () {

		rogueInfo = true;
	}

	void OnMouseExit () {

		rogueInfo = false;
	}
}
