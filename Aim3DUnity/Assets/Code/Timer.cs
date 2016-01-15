using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	[SerializeField]
	private float timeLeft = 8.0f;

	[SerializeField]
	private Text timerText;

	[SerializeField]
	private Text timerText2;
	
	void Update()
	{
		if (timeLeft <= 0) 
		{
			GameOver ();
		} 
		else 
		{
			timeLeft -= Time.deltaTime;
			timerText.text = (""+Mathf.Round(timeLeft));
			timerText2.text = (""+Mathf.Round(timeLeft));
		}
	}

	public void GameOver(){
        Application.LoadLevel("MousePlayerWin");
    }
}
