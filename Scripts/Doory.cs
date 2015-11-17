using UnityEngine;
using System.Collections;

public class Doory : MonoBehaviour {

	Animator anim;
	AudioSource audioSource;

	void Awake () {
		anim = GetComponent<Animator> ();
		audioSource = GetComponent<AudioSource> ();
	}
	


	void OnTriggerEnter(Object collider) {
		anim.SetBool ("ShouldOpen", true);
		audioSource.Play ();
	}

	void OnTriggerExit(Object collider) {
		anim.SetBool ("ShouldOpen", false);
		audioSource.Play ();
	}
}
