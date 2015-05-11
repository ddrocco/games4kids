using UnityEngine;
using System.Collections;

public class CharacterControl : MonoBehaviour {
	public Rigidbody body;
	const float speedScale = 100;
	const float maxSpeed = 200;

	void Start () {
		body = GetComponent<Rigidbody>();
	}
	
	void Update () {
		if (Input.GetKey(KeyCode.A)) {
			body.AddForce(Vector3.left * Time.deltaTime * speedScale);
		}
		if (Input.GetKey(KeyCode.S)) {
			body.AddForce(Vector3.down * Time.deltaTime * speedScale);
		}
		if (Input.GetKey(KeyCode.D)) {
			body.AddForce(Vector3.right * Time.deltaTime * speedScale);
		}
		if (Input.GetKey(KeyCode.W)) {
			body.AddForce(Vector3.up * Time.deltaTime * speedScale);
		}
		
		float speed = body.velocity.magnitude;
		if (speed > maxSpeed) {
			body.velocity = body.velocity.normalized * maxSpeed;
		}
	}
}
