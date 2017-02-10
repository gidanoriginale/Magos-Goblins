using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class ControlTextos : MonoBehaviour {

	public ArrayList party;

	public Text wName;
	public Text wText;
	public Text rName;
	public Text rText;
	public Text mName;
	public Text mText;
	public Text aName;
	public Text aText;
	public Text cName;
	public Text cText;

	// Use this for initialization
	void Start () {
		resetText ();
	}


	private void resetText (){
		wName.enabled = false;
		wText.enabled = false;
		rName.enabled = false;
		rText.enabled = false;
		mName.enabled = false;
		mText.enabled = false;
		aName.enabled = false;
		aText.enabled = false;
		cName.enabled = false;
		cText.enabled = false;
	}

	public void enableWarrior (){
		resetText ();
		wName.enabled = true;
		wText.enabled = true;
	}


	public void enableRogue (){
		resetText ();

		rName.enabled = true;
		rText.enabled = true;
	}

	public void enableMage (){
		resetText ();
		mName.enabled = true;
		mText.enabled = true;
	}

	public void enableArcher() {
		resetText ();
		aName.enabled = true;
		aText.enabled = true;

	}
	public void enableCleric() {
		resetText ();
		cName.enabled = true;
		cText.enabled = true;

	}
	public void summonWarrior() {
	

	}
}
