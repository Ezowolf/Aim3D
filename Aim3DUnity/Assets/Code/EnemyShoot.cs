using UnityEngine;
using System.Collections;

public class EnemyShoot : MonoBehaviour {

	[SerializeField]
	private GameObject bulletToFire;

	private bool canIShoot = true;

	public bool amIInRange = false;

	[SerializeField]
	private float shootingInterval = 1;

	// Update is called once per frame
	void Update () {
		if(amIInRange)
		{
			if(canIShoot)
			{
				Instantiate(bulletToFire, this.transform.position, this.transform.localRotation);
				canIShoot = false;
				StartCoroutine(IntervalCompleter());
			}

		}
	}

	IEnumerator IntervalCompleter()
	{
		yield return new WaitForSeconds(shootingInterval);
		canIShoot = true;
	}
}
