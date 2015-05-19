using UnityEngine;
using System.Collections;

public class BurgerScript : MonoBehaviour {

	public Transform spawnPoint;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < -5) {
			GetComponent<SpriteRenderer>().enabled = false;
			GetComponent<Rigidbody2D>().gravityScale = 0;
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
			GetComponent<Rigidbody2D>().angularVelocity = 0;
			transform.position = spawnPoint.position;
			transform.rotation = Quaternion.identity;

		}
	}
}
