using UnityEngine;
using System.Collections;

public class game1HandController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(TouchHelper.TouchedScreen())
		{
			Animation anim = GetComponent<Animation>();
			anim.Play();
		}
	}
}
