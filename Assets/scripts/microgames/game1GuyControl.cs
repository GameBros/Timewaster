using UnityEngine;
using System.Collections;

public class game1GuyControl : MonoBehaviour {
	public float moveSp;
	public float rotateSp;
	public bool goodGuy;
	public GameObject ashParticles;
	private Vector3 dir;

	// Use this for initialization
	void Start () {
		dir = Vector3.right;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate(dir*moveSp, Space.World);
		transform.Rotate(new Vector3(0,0,1)*rotateSp);
	}
}
