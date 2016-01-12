using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthAndDie : MonoBehaviour {

    public int health = 10;

	private bool died = false;
	public GameObject LooseText;

	// Update is called once per frame
	void Update () {
			
		if (this.gameObject.name == "PlayableCharacter") {
			HealthUIChanger.uIstate = health;
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