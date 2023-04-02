using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collChange : MonoBehaviour {
	public GameObject[] coll;
	// Use this for initialization
	void Start () {
		gameObject.GetComponent<PolygonCollider2D> ().points = coll[move.index].
			GetComponent<PolygonCollider2D> ().points;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
