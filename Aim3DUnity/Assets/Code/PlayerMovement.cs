using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10.0F;
    public float rotationSpeed = 100.0F;
    private Rigidbody rb;
    private float jumpForce = 250;



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
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(transform.up * jumpForce);
        }
    }


}
