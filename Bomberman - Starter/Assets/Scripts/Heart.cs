﻿using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Lifetime;
using UnityEngine;

public class Heart : MonoBehaviour {
	
	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {}

	public void OnTriggerEnter(Collider other) {
		if (other.CompareTag("Player")) {
			var player = other.GetComponent<Player>();
			player.life++;
			Destroy(this.gameObject);
		}
	}
}
