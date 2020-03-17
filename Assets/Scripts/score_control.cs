using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_control : MonoBehaviour
{
    public int score = 0;
    public int highScore;

    public void UpdateScore()
    {
        GetComponent<Text>().text = "Score: " + score;
    }

    public void UpdateHighScore()
    {
        if(score > highScore)
        {
            highScore = score;
        }
        GetComponent<Text>().text = "High Score: " + highScore;
        PlayerPrefs.SetInt("highScore", highScore);
    }

}
