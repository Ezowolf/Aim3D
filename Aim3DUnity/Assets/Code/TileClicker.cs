using UnityEngine;
using System.Collections;

public class TileClicker : MonoBehaviour {

	private bool haveISpawned = false;
	private bool isCharacterOnMe = false;

	private GameObject[] objectsISpawn;
	private GameObject playerTwo;
	private MousePlayer secondPlayerScript;

	// Use this for initialization
	void Start () {
		playerTwo = GameObject.Find("MousePlayer");
		secondPlayerScript = playerTwo.GetComponent<MousePlayer>();
		objectsISpawn = secondPlayerScript.yourObjectArray;
	}
	
	void OnMouseUp()
	{
		if(haveISpawned==false&&isCharacterOnMe==false&&secondPlayerScript.myBuildingPoints>=secondPlayerScript.buildingCosts[secondPlayerScript.whatToSpawnInt])
		{
			secondPlayerScript.myBuildingPoints = secondPlayerScript.myBuildingPoints - secondPlayerScript.buildingCosts[secondPlayerScript.whatToSpawnInt];
			haveISpawned=true;
			Instantiate(objectsISpawn[secondPlayerScript.whatToSpawnInt],new Vector3(this.transform.position.x,(this.transform.position.y+objectsISpawn[secondPlayerScript.whatToSpawnInt].transform.localScale.y+this.transform.localScale.y),this.transform.position.z),Quaternion.identity);
		}
	}

	void OnCollisionEnter(Collision coll)
	{
		if(coll.gameObject.tag=="Player"||coll.gameObject.tag=="Enemy")
		{
			isCharacterOnMe = true;
		}
	}

	void OnCollisionExit(Collision coll)
	{
		if (coll.gameObject.tag == "Player" || coll.gameObject.tag == "Enemy") 
		{
			isCharacterOnMe = false;
		}
	}
}
