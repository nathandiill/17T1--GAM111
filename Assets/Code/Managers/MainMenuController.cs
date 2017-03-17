using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour {

    public Text HighScore;
    public int newHighScore;

	void Start ()
    {
        // Retrieve high score from the "score" script to be displayed on the main menu
        // GameObject.Find("highScore").GetComponent<Score>().highScore = newHighScore;
    }
	
	void Update ()
    {
        HighScore.text = string.Format("High Score: " + newHighScore);
    }
}
