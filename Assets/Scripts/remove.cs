using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class remove : MonoBehaviour {
	public Vector3 pos = new Vector3(-13.29f,-2.19f);
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D coll) {
		Destroy (coll.gameObject);
	}
}
