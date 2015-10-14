using UnityEngine;
using System.Collections;

public class FailOnCollide : MonoBehaviour {
	public GameController gameController;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) 
	{
		GetComponent<AudioSource>().Play();
		gameController.setState(GameState.Fail);
	}
}
