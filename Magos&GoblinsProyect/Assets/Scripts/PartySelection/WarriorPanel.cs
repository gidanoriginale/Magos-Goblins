using UnityEngine;
using System.Collections;

public class WarriorPanel : MonoBehaviour {

	public bool warriorInfo =false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseEnter () {

		warriorInfo = true;
	}

	void OnMouseExit () {

		warriorInfo = false;
	}
}
