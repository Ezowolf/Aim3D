using UnityEngine;
using System.Collections;

public class WinPickup : MonoBehaviour {

	private bool winner = false;
	public GameObject WinText;

	void Update (){
		IfActive ();
	}

	void OnTriggerEnter(Collider coll)
	{
		if(coll.gameObject.tag=="WinPickup")
		{
			Debug.Log("hi");
			winner = true;
			Destroy(coll.gameObject);
		}
	}

	public void IfActive (){
		if(winner == true){
 			WinText.SetActive(true);
		}
	}
}