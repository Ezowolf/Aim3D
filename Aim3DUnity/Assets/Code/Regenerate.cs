using UnityEngine;
using System.Collections;

public class Regenerate : MonoBehaviour {

	[SerializeField]
	private int intervalLength = 1;

	[SerializeField]
	private int addedPoints = 1;

	private MousePlayer scriptToEdit;

	// Use this for initialization
	void Start () {
		scriptToEdit = GetComponent<MousePlayer> ();
		StartCoroutine (IntervalCompleter());
	}

	IEnumerator IntervalCompleter()
	{
		yield return new WaitForSeconds(intervalLength);
		scriptToEdit.myBuildingPoints = scriptToEdit.myBuildingPoints + addedPoints;
		StartCoroutine (IntervalCompleter());
		//Gain X extra points every Y seconds
	}
}
