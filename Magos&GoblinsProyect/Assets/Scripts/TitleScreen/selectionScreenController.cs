using UnityEngine;
using System.Collections;

public class selectionScreenController : MonoBehaviour {

	new Vector3 posicionInicial;
	new Vector3 posicionFinal;

	void Start () {
		posicionInicial = new Vector3(this.transform.localPosition.x, this.transform.localPosition.y, this.transform.localPosition.z);
		posicionFinal = new Vector3 (this.transform.localPosition.x, this.transform.localPosition.y -90, this.transform.localPosition.z);
	}
		
	void Update () {

//		Debug.Log (posicionInicial.y);

		if (Input.GetKeyDown(KeyCode.DownArrow)) {			
			Vector3 nuevaPosicion = new Vector3 (this.transform.localPosition.x, this.transform.position.y -30, this.transform.localPosition.z);
			if (this.GetComponent<RectTransform>().localPosition.y > -165) {
				this.transform.localPosition = new Vector3 (this.transform.localPosition.x, this.transform.localPosition.y -30, this.transform.localPosition.z);
			} else {
				this.transform.localPosition = posicionInicial;
			}
		}

		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			Vector3 nuevaPosicion = new Vector3 (this.transform.localPosition.x, this.transform.localPosition.y +30, this.transform.localPosition.z);
			if (this.GetComponent<RectTransform>().localPosition.y < -75) {
				this.transform.localPosition = nuevaPosicion;
			} else {
				this.transform.localPosition = posicionFinal;
			}
		}

		if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return)) {
			if (transform.localPosition.y == -75) {
				Debug.Log ("aaa");
			}
		}

	}
}
