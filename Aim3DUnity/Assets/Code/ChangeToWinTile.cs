using UnityEngine;
using System.Collections;

public class ChangeToWinTile : MonoBehaviour {
	[SerializeField]
	private GameObject winTile;
	
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "WinningPickup") 
		{
			Instantiate (winTile);
			Destroy (this.gameObject);
		}
	}
}
