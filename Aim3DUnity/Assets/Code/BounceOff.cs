using UnityEngine;
using System.Collections;

public class BounceOff : MonoBehaviour {

	[SerializeField]
	private string whatToBounceOff;

	[SerializeField]
	private float bounceSpeed;

	[SerializeField]
	private int bounceSeconds = 10;

	private MoveForward moveBackwardHere;

	private float originalSpeed = 0;

	void Start()
	{
		moveBackwardHere = GetComponent<MoveForward>();
	}

	void OnTriggerEnter(Collider coll)
	{
		if(coll.gameObject.tag == whatToBounceOff)
		{
			moveBackwardHere.moveSpeed = originalSpeed;
			moveBackwardHere.moveSpeed = moveBackwardHere.moveSpeed* - bounceSpeed;
			StartCoroutine(Unbounce());
		}
	}

	IEnumerator Unbounce()
	{
		yield return new WaitForSeconds(bounceSeconds);
		moveBackwardHere.moveSpeed = originalSpeed;
		Debug.Log("SQUAAA");
	}
}
