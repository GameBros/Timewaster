using UnityEngine;
using System.Collections;

public class TitleManager : MonoBehaviour {

	GameManager gameManager;

	// Use this for initialization
	void Start () {
		gameManager = GameManager.Instance ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			gameManager.Quit();
		}
	}
}
