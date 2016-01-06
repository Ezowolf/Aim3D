using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {

    
	public float moveSpeed = 1;

	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
		//Move forward!
    }
}