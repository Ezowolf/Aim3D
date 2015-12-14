using UnityEngine;
using System.Collections;

public class RotateTowardsTransform : MonoBehaviour {
	[SerializeField]
	private GameObject transformToFollow;

	// Use this for initialization
	void Start () {
		transformToFollow = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if(transformToFollow!=null)
		this.transform.LookAt(transformToFollow.transform);
	}
}
