using UnityEngine;
using System.Collections;

public class GridSystem : MonoBehaviour {

	[SerializeField]
	private int xGridSize = 25;

	[SerializeField]
	private int yGridSize = 25;

	[SerializeField]
	private int xTileLength = 10;

	[SerializeField]
	private int yTileLength = 10;

	[SerializeField]
	private GameObject gridTile;


	[SerializeField]
	private float height;


	// Use this for initialization
	void Start () {
		for(int counterY = 0; counterY<=yGridSize; counterY++)
		{
			for(int counterX = 0; counterX<=xGridSize; counterX++)
			{
				Instantiate(gridTile ,new Vector3(counterX*xTileLength,height,counterY*yTileLength), Quaternion.identity);
			}
		}

	
	}
}
