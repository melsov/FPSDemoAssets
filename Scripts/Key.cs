using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour {

	public LockableDoor door;
	public AudioClip audio;

	// Use this for initialization
	void Awake () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter() {
		door.isLocked = false;
		AudioSource.PlayClipAtPoint (audio, this.transform.position);
		GameObject.Destroy (this.gameObject);
	}
}
