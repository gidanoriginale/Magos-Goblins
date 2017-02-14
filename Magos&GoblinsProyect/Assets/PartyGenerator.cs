﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PartyGenerator : MonoBehaviour {

	public GameObject warriorPlayer;
	public GameObject roguePlayer;
	public GameObject magePlayer;
	public GameObject archerPlayer;
	public GameObject clericPlayer;

	public GameObject posicion1;
	public GameObject posicion2;
	public GameObject posicion3;
	public GameObject posicion4;

	public ArrayList partyGen;

	public GameObject unitParent;

	// Use this for initialization
	void Start () {

		GameObject partyManager = GameObject.Find ("PartyManager");
		if (partyManager != null) {

			partyGen = partyManager.GetComponent<PartyManager> ().party;

			GameObject firstMember = Instantiate ((GameObject)partyGen [0], new Vector2 (posicion1.transform.position.x,posicion1.transform.position.y),transform.rotation) as GameObject;
			firstMember.transform.parent = unitParent.transform;

			GameObject secondMember = Instantiate ((GameObject)partyGen [1], new Vector2 (posicion2.transform.position.x,posicion2.transform.position.y),transform.rotation) as GameObject;
			secondMember.transform.parent = unitParent.transform;

			GameObject thirdMember = Instantiate ((GameObject)partyGen [2], new Vector2 (posicion3.transform.position.x,posicion3.transform.position.y),transform.rotation) as GameObject;
			thirdMember.transform.parent = unitParent.transform;

			GameObject forthMember = Instantiate ((GameObject)partyGen [3], new Vector2 (posicion4.transform.position.x,posicion4.transform.position.y),transform.rotation) as GameObject;
			forthMember.transform.parent = unitParent.transform;
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
