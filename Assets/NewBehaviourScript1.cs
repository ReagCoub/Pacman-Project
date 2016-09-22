using UnityEngine;
using System.Collections;

public class NewBehaviourScript1 : MonoBehaviour

{
	public Rigidbody rb;
	public float speed = 0.3f;
	void Start() {
		rb = GetComponent<Rigidbody>();
	}
	void Update ()
	{
		if (Input.GetKey (KeyCode.LeftArrow)) {
			Vector3 position = this.transform.position;

			rb.velocity = Vector3.left;
			transform.position = position;
		} else if (Input.GetKey (KeyCode.RightArrow)) {
			Vector3 position = this.transform.position;

			rb.velocity = Vector3.right;
			transform.position = position;
		} else if (Input.GetKey (KeyCode.UpArrow)) {
			Vector3 position = this.transform.position;

			rb.velocity = Vector3.up;
			transform.position = position;
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			Vector3 position = this.transform.position;

			rb.velocity = Vector3.down;
			transform.position = position;
		} else {
			 
			//set velocity to zer0
		}
	}

	void OnCollisionEnter (Collision collision) {
		if (collision.contacts [0].point.y < transform.position.y){
			print ("aaahh");
		}
	}
}