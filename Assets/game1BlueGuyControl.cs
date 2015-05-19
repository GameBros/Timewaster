using UnityEngine;
using System.Collections;

public class game1BlueGuyControl : MonoBehaviour {
	public float moveSp;
	public float rotateSp;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate(Vector3.right*moveSp);
		transform.Rotate(new Vector3(0,0,1)*rotateSp);
	}
}
