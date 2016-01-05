using UnityEngine;
using System.Collections;

public class ReenableTile : MonoBehaviour {

	private GameObject myTile;
	private TileClicker scriptToEdit;

	// Use this for initialization
	void Start () {
	
	}
	
	void OnCollisionEnter(Collision coll)
	{
		if (coll.gameObject.tag == "Tile"&&myTile==null&&coll.gameObject.transform.position.x==this.transform.position.x&&coll.gameObject.transform.position.z==this.transform.position.z) 
		{
			myTile = coll.gameObject;
			scriptToEdit = myTile.GetComponent<TileClicker> ();
		}

	}

	void OnDestroy()
	{
		scriptToEdit.haveISpawned = false;


	}
}
