using UnityEngine;
using System.Collections;

public class Timer : HealthAndDie {

	public float timeLeft = 8.0f;
	
	void Update()
	{
		Debug.Log (timeLeft);
		timeLeft -= Time.deltaTime;
		if(timeLeft < 0)
		{
			GameOver();
		}
	}

	public void GameOver(){
		Destroy(this.gameObject);
		LooseText.SetActive(true);
	}
}
