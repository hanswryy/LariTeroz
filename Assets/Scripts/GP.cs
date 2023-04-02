using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GP : MonoBehaviour {
	bool isJump = false;
	public static bool isDead = false;
	int idMove = 0;
	Animator anim;
	GameObject gop;

	public AudioSource jump;
	public AudioSource ded;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (!isDead) {
			if (Input.GetKeyDown(KeyCode.UpArrow)) {
				Jump();
				//jump.Play ();
			}

			if (Input.GetKeyDown (KeyCode.DownArrow)) {
				Down ();
			}
		}

		if (isDead) {
			GameObject.Find ("Player").GetComponent <Animator>().enabled = false;
			GameObject.Find ("groundspawn").GetComponent <show> ().enabled = false;
			GameObject.Find ("enemyspawn").GetComponent <showEnemy> ().enabled = false;
		}
	}

	void OnCollisionEnter2D (Collision2D coll) {
		if (coll.gameObject.name == "rock(Clone)") {
			isDead = true;
			ded.Play ();
		}
	}

	private void OnCollisionStay2D(Collision2D coll) {
		if (isJump) {
			anim.ResetTrigger ("jump");
			if (idMove == 0) {
				anim.SetTrigger ("run");
			}
			isJump = false;
		}
	}

	private void OnCollisionExit2D(Collision2D collision) {
		anim.SetTrigger("jump");
		anim.ResetTrigger("run");
		isJump = true;
	}

	public void Jump() {
		if (!isJump)  {           
			gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 300f);
			jump.Play ();
		}
	}

	public void Down() {
		if (isJump) {
			gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.down * 550f);
		}
	}
}