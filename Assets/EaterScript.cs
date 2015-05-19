using UnityEngine;
using System.Collections;

public class EaterScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (TouchHelper.TouchedScreen ()) {
			GetComponent<Animator>().Play("eater_grab_anim");
		}
	}
}
