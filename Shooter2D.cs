using UnityEngine;
using System.Collections;

public class Shooter2D : MonoBehaviour {
	
	public Rigidbody bullet;
	public float power = 1500f;
	public float moveSpeed =2f;
	private RaycastHit hit;
	
	
	
	// Update is called once per frame
	void Update () {
		
		//Player movement
		float h = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
		float v = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
		
		Vector3 direction = new Vector3(h, v, 0);
		
		transform.Translate(direction);
		
		
		
		//Fire projectile
		if(Input.GetButtonUp("Fire1")) {
			Rigidbody instance = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
			Vector3 fwd = transform.TransformDirection(Vector3.right);
			instance.AddForce (fwd * power);
		}
		
		
		/*
		if(Input.GetButtonUp ("Fire1")) {
			if(Physics.Raycast(transform.position, Vector3.right, out hit, 3.0f)) {
				hit.collider.gameObject.SendMessage("RayHit");
			}
		}
		*/
		
	}
}
