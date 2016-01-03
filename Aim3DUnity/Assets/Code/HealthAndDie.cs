using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthAndDie : MonoBehaviour {

    public int health = 10;

	private bool died = false;
	public GameObject LooseText;

	public Text displayHealth;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (displayHealth != null) {
			displayHealth.text = "Health: " + health;
		}
	    if(health<=0)
        {
            Destroy(this.gameObject);
			if (this.gameObject.tag == "player") 
			{
				LooseText.SetActive (true);
			}
        }
	}
}