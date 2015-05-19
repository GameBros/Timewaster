﻿using UnityEngine;
using System.Collections;

public class Game2Script : MonoBehaviour {

	public Transform burgerMachine;
	public Transform burger;
	public float burgerWaitTime;
	public float burgerGravity;

	private float timer = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer >= burgerWaitTime) {
			timer = 0;
			ProduceBurger();
		}
	}

	void ProduceBurger ()
	{
		burgerMachine.GetComponent<Animator> ().Play ("burgermachine_produce");
		burger.GetComponent<SpriteRenderer> ().enabled = true;
		burger.GetComponent<Rigidbody2D> ().gravityScale = burgerGravity;
	}
}
