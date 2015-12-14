using UnityEngine;
using System.Collections;

public class RotateTowardsTransform : MonoBehaviour {
	[SerializeField]
	private Transform transformToFollow;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.LookAt(transformToFollow);
	}
}
