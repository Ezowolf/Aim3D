using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MousePlayer: MonoBehaviour
{
	public Text buildPointText;
    private Camera camera;

    public int whatToSpawnInt;

	public GameObject[] yourObjectArray;

	public int[] buildingCosts;

	public int myBuildingPoints = 50;

	[SerializeField]
	private int buildingPointsMax = 100;

    private bool ableToPlaceBlocks = true;

    [SerializeField]
    private float maxYPos;
    [SerializeField]
    private float minYPos;

	[SerializeField]
	private float maxXPos;
	[SerializeField]
	private float minXPos;

	[SerializeField]
	private float maxZPos;
	[SerializeField]
	private float minZPos;

    public float dragSpeed = 2;
    private Vector3 dragOrigin;

	private GameObject floorObj;

	private GameObject playerObj;

    void Start()
    {
        camera = GetComponent<Camera>();
		floorObj = GameObject.Find("Floor");
		playerObj = GameObject.FindGameObjectWithTag("Player");
    }

	public void ChangeMySelection(int whatSelection)
	{
		whatToSpawnInt = whatSelection;
		//This changes when player uses the UI
	}
	
    void Update()
    {
        if ((Input.GetAxis("Mouse ScrollWheel") > 0)&& this.transform.position.y < maxYPos)
        {
            transform.Translate((Vector3.up * Time.deltaTime)* 160 * Input.GetAxis("Mouse ScrollWheel") , Space.World);
			//Zoom in
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0 && this.transform.position.y > minYPos)
        {
            transform.Translate((Vector3.up * Time.deltaTime) * 160 * Input.GetAxis("Mouse ScrollWheel"), Space.World);
			//Zoom out
        }
        MouseCameraMovement();
		if (myBuildingPoints > buildingPointsMax) 
		{
			myBuildingPoints = buildingPointsMax;
			//Check to see if building points don't exceed the maximum
		}
		buildPointText.text = "BP: " + myBuildingPoints;

		if (Input.GetMouseButtonDown(2))
		{
			this.transform.position = new Vector3 (playerObj.transform.position.x+12, 22, this.transform.position.z+12);
		}

    }

    void MouseCameraMovement()
    {
        if (Input.GetMouseButtonDown(1))
        {

            dragOrigin = Input.mousePosition;
            return;
        }

        if (!Input.GetMouseButton(1)) return;

        Vector3 pos = camera.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
        Vector3 move = new Vector3(pos.x * dragSpeed, 0, pos.y * dragSpeed);
        transform.Translate(move, Space.World);
		//Move based on dragging the mouse when you right click

    }
}