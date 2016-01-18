using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HealthAndDie : MonoBehaviour {

    public int health = 10;

	private bool died = false;
	public GameObject LooseText;
	[SerializeField]
	private GameObject dieParticle;

	// Update is called once per frame
	void Update () {
			
		if (this.gameObject.name == "PlayableCharacter") {
			HealthUIChanger.uIstate = health;
		}
	    if(health<=0)
        {
            //Destroy this object

            if (this.gameObject.tag == "Player")
            {
                Application.LoadLevel("MousePlayerWin");
                //If the player dies, the gameover text is shown
            }
            else
            {
                Destroy(this.gameObject);
            }
           
        }
	}

	void OnDestroy()
	{
		if(dieParticle!=null)
			Instantiate (dieParticle,this.transform.position,Quaternion.identity);
	}
}