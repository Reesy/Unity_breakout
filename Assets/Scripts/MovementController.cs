using UnityEngine;
using System.Collections;

public class MovementController : MonoBehaviour {
	private Rigidbody rb;

	public int speed;
	public int rotationSpeed;
	public int range;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	
		float translation = Input.GetAxis("Horizontal") * speed;
		translation *= Time.deltaTime;
		transform.Translate(translation, 0, 0);
	}


	void OnCollisionEnter(Collision collision) 
	{
		GetComponent<AudioSource>().Play();

	}
}
