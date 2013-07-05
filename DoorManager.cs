using UnityEngine;
using System.Collections;

public class DoorManager : MonoBehaviour {

	private bool doorIsOpen = false;
	private float doorTimer = 0.0f;
	public float doorOpenTime = 3.0f;
	public AudioClip doorOpenSound;
	public AudioClip doorShutSound;
	
	
	// Use this for initialization
	void Start () {
		doorTimer = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if(doorIsOpen) {
			doorTimer += Time.deltaTime;
		}
		
		if(doorTimer >= doorOpenTime) {
			Door (false, doorShutSound, "doorshut");
			doorTimer = 0f;
		}
	
	}
	
	void DoorCheck() {
		if(!doorIsOpen){
			Door (true, doorOpenSound, "dooropen");	
		}
	}
	
	void Door(bool doorCheck, AudioClip doorSound, string animName) {
		doorIsOpen = doorCheck;
		audio.PlayOneShot(doorSound);
		transform.parent.animation.Play (animName);
	}
}
