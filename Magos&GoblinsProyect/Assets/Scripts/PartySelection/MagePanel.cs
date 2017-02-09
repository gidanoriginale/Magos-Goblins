using UnityEngine;
using System.Collections;

public class MagePanel : MonoBehaviour {

	public bool mageInfo =false;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseEnter () {

		mageInfo = true;
	}

	void OnMouseExit () {

		mageInfo = false;
	}
}
