using UnityEngine;
using System.Collections;

public class LockableDoor : MonoBehaviour {

	public TextMesh message;

	Animator anim;
	AudioSource audioSource;

	private bool locked = true;
	public bool isLocked {
		get {
			return locked;
		}
		set {
			locked = value;
			if (message != null) {
				if (locked) {
					message.text = "Locked";
					message.color = Color.red;
				} else {
					message.text = "Unlocked";
					message.color = Color.green;
				}
			}
		}
	}

	void Awake () {
		anim = GetComponent<Animator> ();
		audioSource = GetComponent<AudioSource> ();
	}

	void OnTriggerEnter(Collider collider) {
		if (!collider.CompareTag ("Player")) {
			return;
		}
		if (locked) {
			print ("door is locked");
			return;
		}
		print ("opening");
		anim.SetBool ("ShouldOpen", true);
		audioSource.Play ();
	}

	void OnTriggerExit(Collider collider) {
		if (!collider.CompareTag ("Player")) {
			return;
		}
		if (locked) {
			return;
		}
		print ("closing");
		anim.SetBool ("ShouldOpen", false);
		audioSource.Play ();
	}
}
