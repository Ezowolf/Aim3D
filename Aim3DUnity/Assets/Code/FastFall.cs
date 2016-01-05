using UnityEngine;
using System.Collections;

public class FastFall : MonoBehaviour {
	private Rigidbody rb;

	[SerializeField]
	private float fallSpeed = 1;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		rb.AddForce(Vector3.down*fallSpeed);
	}
}
