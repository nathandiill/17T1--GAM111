using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public static Score Instance;
   
    void Awake()
    {
        Instance = this;
    }

    public Text CurrentScore;
    public Text HighScore;
    public int newScore;

    public int highScore;
    string highScoreKey = "HighScore";

    void Start ()
    {
        // Retrieve current high score
        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
    }
	
	void Update ()
    {
        CurrentScore.text = string.Format("Current Score: " + newScore);
        HighScore.text = string.Format("High Score: " + highScore);
	}

    void OnDisable()
    {
        // Check if the high score was beat, if so update it
        if(newScore > highScore)
        {
            PlayerPrefs.SetInt(highScoreKey, newScore);
            PlayerPrefs.Save();
        }
    }

    // Reusable function when score needs to be applied
    public int UmpireScore(int pointValue)
    {
        pointValue = 10;
        newScore = pointValue + newScore;
        return newScore;
    }

    // Reusable function when score needs to be applied
    public int TennisNetScore(int pointValue)
    {
        pointValue = -5;
        newScore = pointValue + newScore;
        return newScore;
    }


}
