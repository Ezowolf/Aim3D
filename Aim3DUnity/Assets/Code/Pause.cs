using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	private bool pause = false;

	// Update is called once per frame
	void Update () {
	
	}

	public void PauseIsTrue () {
		pause = true;
		if (pause == true) {
			Time.timeScale = 0;
			Debug.Log ("ik pauzeer" + Time.timeScale);
		} 
	}

	public void PauseIsFalse () {
		pause = false;
		if (pause == false) {
			Time.timeScale = 1;
			Debug.Log ("ik werk" + Time.timeScale);
		}
	}
}
