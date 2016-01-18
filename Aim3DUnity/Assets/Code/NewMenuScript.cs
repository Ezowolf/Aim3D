using UnityEngine;
using System.Collections;

public class NewMenuScript : MonoBehaviour {

	private float state = 1;

	private bool isMenuActivve = true;

	private SpriteRenderer spriteRenderer;

	[SerializeField]
	private Sprite state1Sprite;

	[SerializeField]
	private Sprite state2Sprite;

	[SerializeField]
	private Sprite state3Sprite;

	[SerializeField]
	private Sprite creditsScreenSprite;

	[SerializeField]
	private Sprite howToPlayScreen;

	private ChangeScene sceneChanger;

	[SerializeField]
	private GameObject title;

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>();
		sceneChanger = GetComponent<ChangeScene> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (state > 3) 
		{
			state = 1;
		}
		if (state < 1) 
		{
			state = 3;
		}

		if (isMenuActivve) {
			title.SetActive (true);
			if (Input.GetKeyDown (KeyCode.W)) {
				state--;
			}

			if (Input.GetKeyDown (KeyCode.S)) {
				state++;
			}

			if (Input.GetKeyDown (KeyCode.LeftControl)) {
				if (state == 1) {
					sceneChanger.ChangeToScene (0);
				}
				if (state == 2) {
					Debug.Log ("HTP");
				}
				if (state == 3||state == 2) {
					isMenuActivve = false;
				}
			}

			if (state == 1) {
				spriteRenderer.sprite = state1Sprite;
			}

			if (state == 2) {
				spriteRenderer.sprite = state2Sprite;
			}
			if (state == 3) {
				spriteRenderer.sprite = state3Sprite;
			}
		} 
		else 
		{
			title.SetActive (false);
			if (state == 3) {
				spriteRenderer.sprite = creditsScreenSprite;
			}
			if (state == 2) {
				spriteRenderer.sprite = howToPlayScreen;
			}
			if (Input.GetKeyDown (KeyCode.Escape)) 
			{
				isMenuActivve = true;
			}
		}
	}
}
