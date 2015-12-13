using UnityEngine;
using System.Collections;

public class HealthAndDie : MonoBehaviour {

    [SerializeField]
    private int health = 10;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(health<=0)
        {
            Destroy(this.gameObject);
        }
	}
}
