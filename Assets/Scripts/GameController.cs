using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public enum GameState{
	Running,
	Paused,
	Menu,
	Fail
};

//This is the script that controlls the scene, this will keep and display score
public class GameController : MonoBehaviour {
	private int score = 0;
	public Text ScoreText;
	public GameState gameState;

	public void addScore(int points){
		score += points;
		ScoreText.text = "Score: " + score.ToString(); 
		//print ("Current score is: " + score);

	}

	public void setState(GameState inputState){
		this.gameState = inputState;
	}

	// Use this for initialization
	void Start () {

		//initialises the value of scoreText
		ScoreText.text = "Score: 0"; 
	}
	
	// Update is called once per frame
	void Update () {
		if(gameState == GameState.Fail){
			ScoreText.text = "FAILURE";
		}
	}
}
