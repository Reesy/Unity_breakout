using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {
	private Rigidbody rb;
	public float speed;
	// Use this for initialization

	void Start () {
		rb = GetComponent<Rigidbody>();
	//	rb.AddForce(0, 0, speed);
		rb.AddRelativeForce(0, 0, speed);
	}


	// Update is called once per frame
	void Update () {
		//rb.AddForce(0, 0, speed);
	}
}
