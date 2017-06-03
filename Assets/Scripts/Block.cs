﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {
	
	private void Start() {
		GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 30f;
	}

	private void Update() {
		if (transform.position.y < -2f) {
			Destroy(gameObject);
		}
	}
}
