using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthUIChanger : MonoBehaviour {

	[SerializeField]
	private Sprite sprite1;

	[SerializeField]
	private Sprite sprite2;

	[SerializeField]
	private Sprite sprite3;

	[SerializeField]
	private Sprite sprite4;

	[SerializeField]
	private Sprite sprite5;

	public static int uIstate = 999;

	void Update () {
		if (uIstate == 5) {
			gameObject.GetComponent<Image> ().sprite = sprite1;
		}
		if (uIstate == 4) {
			gameObject.GetComponent<Image> ().sprite = sprite2;
		}
		if (uIstate == 3) {
			gameObject.GetComponent<Image> ().sprite = sprite3;
		}
		if (uIstate == 2) {
			gameObject.GetComponent<Image> ().sprite = sprite4;
		}
		if (uIstate == 1) {
			gameObject.GetComponent<Image> ().sprite = sprite5;
		}
	}
}
