using UnityEngine;
using System.Collections;

public class selectionScreenController : MonoBehaviour {

	new Vector3 posicionInicial;
	new Vector3 posicionFinal;

	// Use this for initialization
	void Start () {
		posicionInicial = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
		posicionFinal = new Vector3 (this.transform.position.x, this.transform.position.y -60, this.transform.position.z);
	}

	// Update is called once per frame
	void Update () {

		//Debug.Log (transform.localPosition.y);

		if (Input.GetKeyDown(KeyCode.DownArrow)) {			
			Vector3 nuevaPosicion = new Vector3 (this.transform.position.x, this.transform.position.y -30, this.transform.position.z);
			if (this.GetComponent<RectTransform>().localPosition.y > -135) {
				this.transform.position = nuevaPosicion;
			} else {
				this.transform.position = posicionInicial;
			}
		}

		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			Vector3 nuevaPosicion = new Vector3 (this.transform.position.x, this.transform.position.y +30, this.transform.position.z);
			if (this.GetComponent<RectTransform>().localPosition.y < -75) {
				this.transform.position = nuevaPosicion;
			} else {
				this.transform.position = posicionFinal;
			}
		}

		if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return)) {
			if (transform.localPosition.y == -35) {
				Debug.Log ("aaa");
			}
		}

	}
}
