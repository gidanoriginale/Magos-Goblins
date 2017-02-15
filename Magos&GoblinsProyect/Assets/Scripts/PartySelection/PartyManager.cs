using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class PartyManager : MonoBehaviour {

	public ArrayList party = new ArrayList();
	private GameObject[] partyList;

	public GameObject warrior;
	public GameObject rogue;
	public GameObject mage;
	public GameObject archer;
	public GameObject cleric;

	public GameObject partyHard;

	public Canvas partyConfirmation;

	// Use this for initialization
	void Start () {	

		partyConfirmation.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void summonWarrior () {

		if (party.Count == 3) {

			party.Add(warrior);
			GameObject Warrior = Instantiate (Resources.Load ("Prefabs/Warrior"), new Vector2 (7.5f, -1.2f), transform.rotation) as GameObject;
			Warrior.transform.localScale = new Vector2 (4, 4);
			Warrior.transform.parent = partyHard.transform;
		}


		if (party.Count == 2) {

			party.Add(warrior);
			GameObject Warrior = Instantiate (Resources.Load ("Prefabs/Warrior"), new Vector2 (5, 0.2f), transform.rotation) as GameObject;
			Warrior.transform.localScale = new Vector2 (4, 4);
			Warrior.transform.parent = partyHard.transform;
		}

		if (party.Count == 1) {

			party.Add(warrior);
			GameObject Warrior = Instantiate (Resources.Load ("Prefabs/Warrior"), new Vector2 (7.5f, 1.6f), transform.rotation) as GameObject;
			Warrior.transform.localScale = new Vector2 (4, 4);
			Warrior.transform.parent = partyHard.transform;
		}

		if (party.Count == 0) {

			party.Add(warrior);
			GameObject Warrior = Instantiate (Resources.Load ("Prefabs/Warrior"), new Vector2 (5, 3), transform.rotation) as GameObject;
			Warrior.transform.localScale = new Vector2 (4, 4);
			Warrior.transform.parent = partyHard.transform;
		}
	}

	public void summonRogue () {

		if (party.Count == 3) {

			party.Add(rogue);
			GameObject Rogue = Instantiate (Resources.Load ("Prefabs/Rogue"), new Vector2 (7.5f, -1.2f), transform.rotation) as GameObject;
			Rogue.transform.localScale = new Vector2 (4, 4);
			Rogue.transform.parent = partyHard.transform;
		}


		if (party.Count == 2) {

			party.Add(rogue);
			GameObject Rogue = Instantiate (Resources.Load ("Prefabs/Rogue"), new Vector2 (5, 0.2f), transform.rotation) as GameObject;
			Rogue.transform.localScale = new Vector2 (4, 4);
			Rogue.transform.parent = partyHard.transform;
		}

		if (party.Count == 1) {

			party.Add(rogue);
			GameObject Rogue = Instantiate (Resources.Load ("Prefabs/Rogue"), new Vector2 (7.5f, 1.6f), transform.rotation) as GameObject;
			Rogue.transform.localScale = new Vector2 (4, 4);
			Rogue.transform.parent = partyHard.transform;
		}

		if (party.Count == 0) {

			party.Add(rogue);
			GameObject Rogue = Instantiate (Resources.Load ("Prefabs/Rogue"), new Vector2 (5, 3), transform.rotation) as GameObject;
			Rogue.transform.localScale = new Vector2 (4, 4);
			Rogue.transform.parent = partyHard.transform;
		}
	}

	public void summonMage () {

		if (party.Count == 3) {

			party.Add(mage);
			GameObject Mage = Instantiate (Resources.Load ("Prefabs/Mage"), new Vector2 (7.5f, -1.2f), transform.rotation) as GameObject;
			Mage.transform.localScale = new Vector2 (4, 4);
			Mage.transform.parent = partyHard.transform;
		}


		if (party.Count == 2) {

			party.Add(mage);
			GameObject Mage = Instantiate (Resources.Load ("Prefabs/Mage"), new Vector2 (5, 0.2f), transform.rotation) as GameObject;
			Mage.transform.localScale = new Vector2 (4, 4);
			Mage.transform.parent = partyHard.transform;
		}

		if (party.Count == 1) {

			party.Add(mage);
			GameObject Mage = Instantiate (Resources.Load ("Prefabs/Mage"), new Vector2 (7.5f, 1.6f), transform.rotation) as GameObject;
			Mage.transform.localScale = new Vector2 (4, 4);
			Mage.transform.parent = partyHard.transform;
		}

		if (party.Count == 0) {

			party.Add(mage);
			GameObject Mage = Instantiate (Resources.Load ("Prefabs/Mage"), new Vector2 (5, 3), transform.rotation) as GameObject;
			Mage.transform.localScale = new Vector2 (4, 4);
			Mage.transform.parent = partyHard.transform;
		}
	}

	public void summonArcher () {

		if (party.Count == 3) {

			party.Add(archer);
			GameObject Archer = Instantiate (Resources.Load ("Prefabs/Archer"), new Vector2 (7.5f, -1.2f), transform.rotation) as GameObject;
			Archer.transform.localScale = new Vector2 (4, 4);
			Archer.transform.parent = partyHard.transform;
		}


		if (party.Count == 2) {

			party.Add(archer);
			GameObject Archer = Instantiate (Resources.Load ("Prefabs/Archer"), new Vector2 (5, 0.2f), transform.rotation) as GameObject;
			Archer.transform.localScale = new Vector2 (4, 4);
			Archer.transform.parent = partyHard.transform;
		}

		if (party.Count == 1) {

			party.Add(archer);
			GameObject Archer = Instantiate (Resources.Load ("Prefabs/Archer"), new Vector2 (7.5f, 1.6f), transform.rotation) as GameObject;
			Archer.transform.localScale = new Vector2 (4, 4);
			Archer.transform.parent = partyHard.transform;
		}

		if (party.Count == 0) {

			party.Add(archer);
			GameObject Archer = Instantiate (Resources.Load ("Prefabs/Archer"), new Vector2 (5, 3), transform.rotation) as GameObject;
			Archer.transform.localScale = new Vector2 (4, 4);
			Archer.transform.parent = partyHard.transform;
		}
	}

	public void summonCleric () {

		if (party.Count == 3) {

			party.Add(cleric);
			GameObject Cleric = Instantiate (Resources.Load ("Prefabs/Cleric"), new Vector2 (7.5f, -1.2f), transform.rotation) as GameObject;
			Cleric.transform.localScale = new Vector2 (4, 4);
			Cleric.transform.parent = partyHard.transform;
		}


		if (party.Count == 2) {

			party.Add(cleric);
			GameObject Cleric = Instantiate (Resources.Load ("Prefabs/Cleric"), new Vector2 (5, 0.2f), transform.rotation) as GameObject;
			Cleric.transform.localScale = new Vector2 (4, 4);
			Cleric.transform.parent = partyHard.transform;
		}

		if (party.Count == 1) {

			party.Add(cleric);
			GameObject Cleric = Instantiate (Resources.Load ("Prefabs/Cleric"), new Vector2 (7.5f, 1.6f), transform.rotation) as GameObject;
			Cleric.transform.localScale = new Vector2 (4, 4);
			Cleric.transform.parent = partyHard.transform;
		}

		if (party.Count == 0) {

			party.Add(cleric);
			GameObject Cleric = Instantiate (Resources.Load ("Prefabs/Cleric"), new Vector2 (5, 3), transform.rotation) as GameObject;
			Cleric.transform.localScale = new Vector2 (4, 4);
			Cleric.transform.parent = partyHard.transform;
		}
	}

	public void Desummon () {

		partyList = GameObject.FindGameObjectsWithTag ("Player");
		party.RemoveRange (0, party.Count);

		foreach (GameObject member in partyList) {
		
			Destroy (member);
		}
	}

	public void AcceptParty() {
		
		if (party.Count >= 3) {
		
			partyConfirmation.enabled = true;
		}
	}

	public void YesYes () {

		DontDestroyOnLoad (this.gameObject);
		SceneManager.LoadScene ("Introduction1");
	}

	public void NoNoNo () {

		partyConfirmation.enabled = false;
	}
}
