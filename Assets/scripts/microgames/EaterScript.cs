using UnityEngine;
using System.Collections;

public class EaterScript : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (TouchHelper.TouchedScreen ()) {
			if(anim.GetCurrentAnimatorStateInfo(0).IsName("eater_wait_anim")){
				anim.Play("eater_grab_anim");
			}
		}
	}
}
