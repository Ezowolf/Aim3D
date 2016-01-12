using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthAndDie : MonoBehaviour {

    public int health = 10;

	private bool died = false;
	public GameObject LooseText;

	public Text displayHealth;
	
	// Update is called once per frame
	void Update () {
		if (displayHealth != null) {
			displayHealth.text = "Health: " + health;
			HealthUIChanger.uIstate = health;
			//In case you want to show the health in the UI
		}
	    if(health<=0)
        {
			//Destroy this object
            Destroy(this.gameObject);
			if (this.gameObject.tag == "player") 
			{
				LooseText.SetActive (true);
				//If the player dies, the gameover text is shown
			}
        }
	}
}