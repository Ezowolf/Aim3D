using UnityEngine;
using System.Collections;

public class RotateTowardsTransform : MonoBehaviour {
	[SerializeField]
	private GameObject transformToFollow;
	
	void Start () {
		transformToFollow = GameObject.FindWithTag("Player");
	}

	void Update () {
		if(transformToFollow!=null)
		this.transform.LookAt(transformToFollow.transform);
	}
}