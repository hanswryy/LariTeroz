using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showEnemy : MonoBehaviour {
	public static float[] ivl = {2, 4};
	public GameObject enemy;
	public static int idx;
	GameObject temp;
	float timer;
	// Use this for initialization
	void Start () {
		Instantiate (enemy, transform.position, transform.rotation);
		idx = Random.Range (0, 2);
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > ivl[idx]) {
			Instantiate (enemy, transform.position, transform.rotation);
			timer = 0;
			idx = Random.Range (0, 2);
		}
	}
}
