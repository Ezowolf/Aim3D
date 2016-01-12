using UnityEngine;
using System.Collections;

public class ShootBullet : MonoBehaviour {
    [SerializeField]
    private GameObject bulletToFire;

    private bool canIShoot = true;

    [SerializeField]
    private float shootingInterval = 1;

	[SerializeField]
	private Vector3 relativeFiringPosition = new Vector3(0,0,0);

	[SerializeField]
	private AudioSource laserShot;

	[SerializeField]
	private AudioClip laserSound;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetButtonDown("Fire1"))
        {
			//Can i shoot?
            if(canIShoot)
            {
				//Fires the bullet
				laserShot.PlayOneShot(laserSound);
				Instantiate(bulletToFire, this.transform.position+relativeFiringPosition, this.transform.localRotation);
                canIShoot = false;
				//Disables the ability to shoot for a customisable anmount of time so the player can't just "mash"
                StartCoroutine(IntervalCompleter());
            }
            
        }
	}

    IEnumerator IntervalCompleter()
    {
		//Ables the player to shoot a bullet again
        yield return new WaitForSeconds(shootingInterval);
        canIShoot = true;
    }
}