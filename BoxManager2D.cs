using UnityEngine;
using System.Collections;

public class BoxManager2D : MonoBehaviour {
	
	RaycastHit hit;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	
	void RayHit() {
		transform.Translate (Vector3.up);	
	}
	
	void OnTriggerEnter(Collider col) {
		RayHit();
	}
}
