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
	
    void Start()
    {
        camera = GetComponent<Camera>();
		floorObj = GameObject.Find("Floor");
    }

	public void ChangeMySelection(int whatSelection)
	{
		whatToSpawnInt = whatSelection;
	}
	
    void Update()
    {
		Debug.Log (myBuildingPoints);
        if ((Input.GetAxis("Mouse ScrollWheel") > 0)&& this.transform.position.y < maxYPos)
        {
            transform.Translate((Vector3.up * Time.deltaTime)* 160 * Input.GetAxis("Mouse ScrollWheel") , Space.World);
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0 && this.transform.position.y > minYPos)
        {
            transform.Translate((Vector3.up * Time.deltaTime) * 160 * Input.GetAxis("Mouse ScrollWheel"), Space.World);
        }
        MouseCameraMovement();
		myBuildingPoints++;
		if (myBuildingPoints > buildingPointsMax) 
		{
			myBuildingPoints = buildingPointsMax;
		}
		buildPointText.text = "BP: " + myBuildingPoints;

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
    }
}