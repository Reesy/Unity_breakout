using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	private Rigidbody rb;
	public float speed;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();

		
	}
	
	// Update is called once per frame
	void Update () {
		//get its transform
		float translation = 1 * speed;
		translation *= Time.deltaTime;
		transform.Translate(translation, 0, 0);
	
	}

	void OnCollisionEnter(Collision other){
		Debug.Log("Collided");
	//  Debug.Log(this.transform.eulerAngles);
	}

	




}
