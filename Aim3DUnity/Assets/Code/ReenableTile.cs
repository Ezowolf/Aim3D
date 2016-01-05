using UnityEngine;
using System.Collections;

public class ReenableTile : MonoBehaviour {

	private bool haveILanded;
	private GameObject myTile;
	private TileClicker scriptToEdit;

	void OnCollisionEnter(Collision coll)
	{
		if (coll.gameObject.tag == "Tile"&&myTile==null&&coll.gameObject.transform.position.x==this.transform.position.x&&coll.gameObject.transform.position.z==this.transform.position.z) 
		{
			haveILanded = true;
			myTile = coll.gameObject;
			scriptToEdit = myTile.GetComponent<TileClicker> ();
		}
	}
	void OnDestroy()
	{
		if (haveILanded) 
		{
			scriptToEdit.haveISpawned = false;
		}
	}
}
