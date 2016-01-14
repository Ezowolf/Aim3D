using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class TileClicker : MonoBehaviour, IPointerClickHandler {

	public bool haveISpawned = false;
	private bool isCharacterOnMe = false;

	private GameObject[] objectsISpawn;
	private GameObject playerTwo;
	private MousePlayer secondPlayerScript;
	private float mousePosition;

	[SerializeField]
	private float tileID;

	[SerializeField]
	private float[] toFillIDs;

	[SerializeField]
	private GameObject unbreakableWall;

	// Use this for initialization
	void Awake () {
		playerTwo = GameObject.Find("MousePlayer");
		secondPlayerScript = playerTwo.GetComponent<MousePlayer>();
		objectsISpawn = secondPlayerScript.yourObjectArray;
		tileID = GridSystem.tileCounter;
		GridSystem.tileCounter++;
	}

	void Start()
	{
		foreach (float fillID in toFillIDs) 
		{
			if (fillID == tileID) 
			{
				Debug.Log ("yah");
				haveISpawned = true;
				Instantiate (unbreakableWall, new Vector3 (this.transform.position.x, (this.transform.position.y + unbreakableWall.transform.localScale.y + this.transform.localScale.y),this.transform.position.z), Quaternion.identity);
			}
		}
	}

	public void OnPointerClick(PointerEventData eventData)
	{
		mousePosition = Input.mousePosition.x;
		if (mousePosition<Screen.width/2&&haveISpawned == false && isCharacterOnMe == false && secondPlayerScript.myBuildingPoints >= secondPlayerScript.buildingCosts [secondPlayerScript.whatToSpawnInt]) {
			//If the mouse is on the screen of the mouse player, the tile is not occupied by a player, or spawned object, and i have enough points to build...
			secondPlayerScript.myBuildingPoints = secondPlayerScript.myBuildingPoints - secondPlayerScript.buildingCosts [secondPlayerScript.whatToSpawnInt];
			//subtract the costs of the object i spawned from my building points
			haveISpawned = true;
			Instantiate (objectsISpawn [secondPlayerScript.whatToSpawnInt], new Vector3 (this.transform.position.x, (this.transform.position.y + objectsISpawn [secondPlayerScript.whatToSpawnInt].transform.localScale.y + this.transform.localScale.y), this.transform.position.z), Quaternion.identity);
			//Mark the tile as occupied and spawn the object based on it's height
		} 
	}

	void OnCollisionEnter(Collision coll)
	{
		if(coll.gameObject.tag=="Player"||coll.gameObject.tag=="Enemy")
		{
			isCharacterOnMe = true;
			//A character is on me, so don't spawn anything on this tile
		}

	}

	void OnCollisionExit(Collision coll)
	{
		if (coll.gameObject.tag == "Player" || coll.gameObject.tag == "Enemy") 
		{
			isCharacterOnMe = false;
			//Vice versa
		}
	}
}