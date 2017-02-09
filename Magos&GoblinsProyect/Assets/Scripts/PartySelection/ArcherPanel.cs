using UnityEngine;
using System.Collections;

public class ArcherPanel : MonoBehaviour {

	public bool archerInfo =false;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnMouseEnter () {

		archerInfo = true;
	}

	void OnMouseExit () {

		archerInfo = false;
	}
}