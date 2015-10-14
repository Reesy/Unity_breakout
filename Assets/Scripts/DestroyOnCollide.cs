using UnityEngine;
using System.Collections;

public class DestroyOnCollide : MonoBehaviour {
	public GameController gameController;
	public GameObject BlockDestroySound;
	// Use this for initialization
	void Start () 
	{
		GameObject gameControllerObject = GameObject.FindWithTag("GameController");
		if(gameControllerObject != null)
		{
			gameController = gameControllerObject.GetComponent<GameController>();
		}
	}

	// Update is called once per frame
	void Update () 
	{
	
	}
	void OnCollisionEnter(Collision collision) 
	{
		gameController.addScore(10);
		Instantiate(BlockDestroySound);
		Destroy(gameObject);
	}
}
