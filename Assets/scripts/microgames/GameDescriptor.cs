using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameDescriptor : MonoBehaviour{

	public Text message;
	public float displayTime;

	private float timer = 0;

	void Start(){
		message.enabled = true;
	}

	void Update(){
		timer += Time.deltaTime;
		if (timer >= displayTime) {
			message.enabled = false;
		}
	}

}
