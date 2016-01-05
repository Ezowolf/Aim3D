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
				if (stopThis != null) 
				{
					stopThis.moveSpeed = 0;
				}
				shootScript.amIInRange = true;
			}
			else
			{
				if (stopThis != null) 
				{
					stopThis.moveSpeed = originalSpeed;
				}
				shootScript.amIInRange = false;
			}
		}
	}
}
