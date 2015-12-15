using UnityEngine;
using System.Collections;

public class MousePlayer: MonoBehaviour
{

    private Camera camera;

    public int whatToSpawnInt;

	public GameObject[] yourObjectArray;

    private float zAxisDistance = 10f;

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
	
    void Update()
    {
		/*zAxisDistance = this.transform.position.y - yourObjectArray[whatToSpawnInt].transform.localScale.y;
		if (Input.GetMouseButtonDown(0))
        {
            var mousePos = Input.mousePosition;
            mousePos.z = zAxisDistance;
            Vector3 objectPos = camera.ScreenToWorldPoint(mousePos);
            Ray ray = camera.ScreenPointToRay(mousePos);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
				if (hit.transform.gameObject.tag == "SpawnedObject"|| hit.transform.gameObject.tag == "UserInterface")
                {
                    ableToPlaceBlocks = false;
                }
                else
                {
                    ableToPlaceBlocks = true;
                }
            }
            if(mousePos.x>Screen.width/2)
            {
                ableToPlaceBlocks = false;
            }
            if (ableToPlaceBlocks)
                Instantiate(yourObjectArray[whatToSpawnInt], objectPos, Quaternion.identity);
        }*/
		
        if ((Input.GetAxis("Mouse ScrollWheel") > 0)&& this.transform.position.y < maxYPos)
        {
            transform.Translate((Vector3.up * Time.deltaTime)* 160 * Input.GetAxis("Mouse ScrollWheel") , Space.World);
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0 && this.transform.position.y > minYPos)
        {
            transform.Translate((Vector3.up * Time.deltaTime) * 160 * Input.GetAxis("Mouse ScrollWheel"), Space.World);
        }

        MouseCameraMovement();
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