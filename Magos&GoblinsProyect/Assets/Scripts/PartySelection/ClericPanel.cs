using UnityEngine;
using System.Collections;

public class ClericPanel : MonoBehaviour {

	public bool clericInfo =false;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseEnter () {

		clericInfo = true;
	}

	void OnMouseExit () {

		clericInfo = false;
	}
}