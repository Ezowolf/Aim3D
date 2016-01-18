using UnityEngine;
using System.Collections;

public class RotateTowardsTransform : MonoBehaviour {
	[SerializeField]
	private GameObject transformToFollow;

	private GameObject playerObject;
	private PlayerMovement movementScript;

	private float bulletSpeed;

	private float travelTime;

	private Vector3 predictedPosition;
	
	void Start () 
	{
		playerObject = GameObject.FindGameObjectWithTag ("Player");
		movementScript = playerObject.GetComponent<PlayerMovement> ();
	}

	void Update () 
	{
		if(playerObject!=null)
		{
		//Rotate towards the player
		bulletSpeed = 10*Time.fixedDeltaTime;
		float playerDistance = Vector3.Distance (transform.position, playerObject.transform.position);
		travelTime = playerDistance / bulletSpeed;
		predictedPosition = playerObject.transform.position + movementScript.playerChange * travelTime;
		this.transform.LookAt(predictedPosition);
		}
}
}