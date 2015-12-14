using UnityEngine;
using System.Collections;

public class HealthAndDie : MonoBehaviour {

    public int health = 10;

	private bool died = false;
	public GameObject LooseText;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if(health<=0)
        {
            Destroy(this.gameObject);
			LooseText.SetActive(true);
        }
	}
}
