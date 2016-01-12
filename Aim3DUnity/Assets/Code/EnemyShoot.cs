using UnityEngine;
using System.Collections;

public class EnemyShoot : MonoBehaviour {

	[SerializeField]
	private GameObject bulletToFire;

	private bool canIShoot = true;

	public bool amIInRange = false;

	[SerializeField]
	private float shootingInterval = 1;

	[SerializeField]
	private AudioSource laserShot;

	[SerializeField]
	private AudioClip laserSound;

	[SerializeField]
	private AudioClip spawnSound;


	void Start()
	{
		laserShot.PlayOneShot (spawnSound);
	}

	void Update () {
		if(amIInRange)
		{
			//If i'm close enough to the player
			if(canIShoot)
			{
				laserShot.PlayOneShot(laserSound);
				Instantiate(bulletToFire, this.transform.position, this.transform.localRotation);
				canIShoot = false;
				StartCoroutine(IntervalCompleter());
				//Starts an interval in which the enemy can not shoot, so that they don't fire an endles stream of bullets.
			}

		}
	}

	IEnumerator IntervalCompleter()
	{
		yield return new WaitForSeconds(shootingInterval);
		canIShoot = true;
		//The enemy can shoot again
	}
}