﻿using UnityEngine;
using System.Collections;

public class MoveForward : MonoBehaviour {

    
	public float moveSpeed = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
    }
}
