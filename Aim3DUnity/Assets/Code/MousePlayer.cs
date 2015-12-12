using UnityEngine;
using System.Collections;

public class MousePlayer: MonoBehaviour
{
    private Camera camera;

    public int whatToSpawnInt;

    [SerializeField]
    private GameObject[] yourObjectArray;

    [SerializeField]
    private float zAxisDistance = 10f;

    // Use this for initialization
    void Start()
    {
        camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var mousePos = Input.mousePosition;
            mousePos.z = zAxisDistance;
            Vector3 objectPos = camera.ScreenToWorldPoint(mousePos);
            Instantiate(yourObjectArray[whatToSpawnInt], objectPos, Quaternion.identity);
        }
    }
}
