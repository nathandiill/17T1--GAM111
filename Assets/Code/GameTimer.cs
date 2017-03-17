using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{

    public Text TimeRemaining;
    public float time;

    void Start()
    {

    }

    void Update()
    {
        time -= Time.deltaTime;

        if (time > 0)
        {
            TimeRemaining.text = string.Format("Time Remaining: " + time);
        }
        else
        {
            SceneManager.LoadScene(5);
        }
    }
}