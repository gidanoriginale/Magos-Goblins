using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InfoPanel : MonoBehaviour {



	// Use this for initialization
	void Start () {

			
	}
	
	// Update is called once per frame
	void Update () {

		if (GetComponent<WarriorPanel> ().warriorInfo == true) {

			foreach (Transform t in transform) {
			
				if (t.name == "WarriorName") {
				
					t.GetComponent<Text> ().enabled = true;
				}
			}
		}
	
	}
}
