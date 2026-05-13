using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    public static int highScore;
    public static int highRating;

    public Endingscreen endingScreen;
    // Update is called once per frame
    void Update()
    {
     if (endingScreen.score > highScore)
        {
            highScore = endingScreen.score;
            highRating = endingScreen.rating;

            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.SetInt("highRating", highRating);
            PlayerPrefs.Save();
        }
    }
}
