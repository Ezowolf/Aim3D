using UnityEngine;
using System.Collections;

public class DestroyAfterSeconds : MonoBehaviour {

    [SerializeField]
    private int howManySeconds = 10;

	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, howManySeconds);
	}
}
