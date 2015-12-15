using UnityEngine;
using System.Collections;

public class ShootBullet : MonoBehaviour {
    [SerializeField]
    private GameObject bulletToFire;

    private bool canIShoot = true;

    [SerializeField]
    private float shootingInterval = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(Input.GetButtonDown("Fire1"))
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