using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scnManager : MonoBehaviour {
	public GameObject button;
	public GameObject Panel;
	public GameObject teks;
	float timer;
	// Use this for initialization
	void Start () {
		button.SetActive (false);
		teks.SetActive (false);
		Panel.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > 7) {
			button.SetActive (true);
			teks.SetActive (true);
		}
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Panel.SetActive (true);
		}
	}

	public void Mulai() {
		SceneManager.LoadScene ("gp");
		//GP.isDead = false;
		//GameObject.Find ("Player").GetComponent <Animator>().enabled = true;
		//GameObject.Find ("groundspawn").GetComponent <show> ().enabled = true;
		//GameObject.Find ("enemyspawn").GetComponent <showEnemy> ().enabled = true;
		//move.speed = 10f;
		//SceneManager.LoadScene ("gp");
	}

	public void Ya() {
		Application.Quit ();
	}

	public void Tidak() {
		Panel.SetActive (false);
	}
}
