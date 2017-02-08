using UnityEngine;
using System.Collections;

public class titleScreenController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 nuevaPosicion = new Vector3 (this.transform.position.x, this.transform.position.y - 30, this.transform.position.z);
		Debug.Log (nuevaPosicion.y);
		if (Input.GetKeyDown(KeyCode.DownArrow)) {

			if (nuevaPosicion.y < -135) {
				this.transform.position = new Vector3 (this.transform.position.x, -75, this.transform.position.z);
			} else {
				this.transform.position = nuevaPosicion;
			}

		}
	}
}
