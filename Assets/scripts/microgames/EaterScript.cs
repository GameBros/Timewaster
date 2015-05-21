using UnityEngine;
using System.Collections;

public class EaterScript : MonoBehaviour {

	Animator anim;
	public ParticleSystem burgerCrumbs;

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

	public void PlayMampf(){
		GetComponent<AudioSource> ().Play ();
		burgerCrumbs.Play ();
	}
}
