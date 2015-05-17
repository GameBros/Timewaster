using UnityEngine;
using System.Collections;

public class Pot_01_Script : MonoBehaviour {

	GameManager gameManager;

	// Use this for initialization
	void Start () {
		gameManager = GameManager.Instance ();
	}
	
	// Update is called once per frame
	void Update () {
		if (TouchHelper.Touched (gameObject)) {
			gameManager.StartMicroGames (0);
		}
	}
}
