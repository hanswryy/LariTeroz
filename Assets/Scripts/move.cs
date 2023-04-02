using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
	public static float speed = 10f;
	public Sprite[] sprites;
	//public GameObject[] coll;
	public static int index;
	// Use this for initialization
	void Start () {
		index = Random.Range (0, sprites.Length);
		gameObject.GetComponent<SpriteRenderer> ().sprite = sprites[index];
		//gameObject.GetComponent<PolygonCollider2D> ().points = coll[index].
		//	GetComponent<PolygonCollider2D> ().points;
	}
	
	// Update is called once per frame
	void Update () {
		float move = (speed * Time.deltaTime * -1f) + transform.position.x;
		transform.position = new Vector3(move, transform.position.y);
		if (GP.isDead) {
			speed = 0;
		}
	}
}