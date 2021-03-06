﻿using UnityEngine;
using System.Collections;

public class DieWhenColliding : MonoBehaviour {

	private HealthAndDie healthScript;

	[SerializeField]
	private string whatTagKillsMe;

	[SerializeField]
	private bool destroyAfterColliding;

	// Use this for initialization
	void Start () {
		healthScript = GetComponent<HealthAndDie>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider coll)
	{
		if(coll.gameObject.tag == whatTagKillsMe)
		{
			if(healthScript!=null)
			healthScript.health--;
			if(destroyAfterColliding)
			Destroy(coll.gameObject);
			//Substracts health if this object collides with a customisable tag.

		}
	}
}