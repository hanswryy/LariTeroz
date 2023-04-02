using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour {
	public static Text txt;
	float scorr;
	int fscore;

	// Use this for initialization
	void Start () {
		txt = GetComponent <Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (!GP.isDead) {
			scorr += 0.25f;
			fscore = Mathf.RoundToInt (scorr);
			txt.text = fscore + "";
		}
	}
}