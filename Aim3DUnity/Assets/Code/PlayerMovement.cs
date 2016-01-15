using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 10.0F;
    [SerializeField]
    private float rotationSpeed = 100.0F;
    private Rigidbody rb;
    [SerializeField]
    private float jumpForce = 250;

    private bool canIJump = false;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

		//Walk and rotate the player

        if (Input.GetButtonDown("Jump")&&canIJump)
        {
			//If the player presses space and has a jumping pickup
            if (Physics.Raycast(transform.position, -Vector3.up, 1 + 0.1F) == true)
            {
                rb.AddForce(transform.up * jumpForce);
				//Jump
            }
        }
    }

    void OnTriggerEnter(Collider coll)
    {
		if (coll.gameObject.tag == "JumpingPickup") {
			canIJump = true;
			Destroy (coll.gameObject);
			//Pick up the jumping pickup
		}
		if (coll.gameObject.tag == "WinPickup") {
            Application.LoadLevel("ControllerPlayerWin");
        }
	}
}