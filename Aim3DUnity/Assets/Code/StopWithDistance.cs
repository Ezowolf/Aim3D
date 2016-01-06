using UnityEngine;
using System.Collections;

public class StopWithDistance : MonoBehaviour {
	private GameObject transformToFollow;

	private MoveForward stopThis;

	private EnemyShoot shootScript;

	[SerializeField]
	private float distanceToStopAt = 3;

	private float originalSpeed = 8;

	// Use this for initialization
	void Start () {
		transformToFollow = GameObject.FindWithTag("Player");
		stopThis = GetComponent<MoveForward>();
		shootScript = GetComponent<EnemyShoot>();
		if(stopThis!=null)
		originalSpeed = stopThis.moveSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		if(transformToFollow!=null)
		{
			if(Vector3.Distance(this.transform.position,transformToFollow.transform.position)<=distanceToStopAt)
			{
				//If i'm close enough
				if (stopThis != null) 
				{
					stopThis.moveSpeed = 0;
					//Stop moving
				}
				shootScript.amIInRange = true;
				//Start shooting
			}
			else
			{
				if (stopThis != null) 
				{
					//If i'm no longer close enough
					stopThis.moveSpeed = originalSpeed;
					//Start moving again
				}
				shootScript.amIInRange = false;
				//Stop shooting
			}
		}
	}
}
