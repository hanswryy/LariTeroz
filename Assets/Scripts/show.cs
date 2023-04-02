using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class show : MonoBehaviour {
	public float jeda;
	float timer;
	float timer2;
	public GameObject grnd;
	GameObject temp;
	// Use this for initialization
	void Start () {
		temp = Instantiate (grnd, transform.position, transform.rotation, transform);
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		timer2 += Time.deltaTime;
		if (timer2 > 7) {
			move.speed *= 1.05f;
			jeda /= 1.05f;
			showEnemy.ivl[showEnemy.idx] /= 1.01f;
			timer2 = 0;
		}
		if (timer > jeda) {
			temp = Instantiate (grnd, transform.position, transform.rotation, transform);
			timer = 0;
		}
	}
}
