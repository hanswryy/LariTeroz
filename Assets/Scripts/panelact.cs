using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class panelact : MonoBehaviour {
	public GameObject panel;
	public GameObject lose;
	public GameObject scoree;
	float timer;
	// Use this for initialization
	void Start () {
		panel.SetActive (false);
		lose.SetActive (false);
		scoree.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (GP.isDead) {
			panel.SetActive (true);
			timer += Time.deltaTime;
			lose.SetActive (true);
			if (timer > 1) {
				scoree.SetActive (true);
				scoree.GetComponent<Text> ().text = "Skor Mu " + score.txt.text;
			}
		}
	}

	public void Ulangi() {
		panel.SetActive (false);
		lose.SetActive (false);
		scoree.SetActive (false);
		GP.isDead = false;
		GameObject.Find ("Player").GetComponent <Animator>().enabled = true;
		GameObject.Find ("groundspawn").GetComponent <show> ().enabled = true;
		GameObject.Find ("enemyspawn").GetComponent <showEnemy> ().enabled = true;
		move.speed = 10f;
		SceneManager.LoadScene ("gp");
	}

	public void Menu() {
		SceneManager.LoadScene ("menu");
	}
}
