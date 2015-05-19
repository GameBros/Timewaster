using UnityEngine;
using System.Collections;

public class TimerunnerScript : MonoBehaviour{

	GameManager gameManager;

	public float time;

	// Use this for initialization
	void Start () {
		gameManager = GameManager.Instance ();
	}
	
	// Update is called once per frame
	void Update () {
		time -= Time.deltaTime;
		if (time <= 0) {
			gameManager.TimeUp();
		}
	}
}
