using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LV2highscore : MonoBehaviour
{
    public static int highScore2;
    public static int highRating2;

    public endingLV2 endingScreen2;

    private const string HIGH_SCORE_KEY = "LV2_HighScore";
    private const string HIGH_RATING_KEY = "LV2_HighRating";
    // Update is called once per frame
    void Update()
    {
        if (endingScreen2.score > highScore2)
        {
            highScore2 = endingScreen2.score;
            highRating2 = endingScreen2.rating;
        }

        SaveHighScore();
    }

    void SaveHighScore()
    {
        PlayerPrefs.SetInt(HIGH_SCORE_KEY, highScore2);
        PlayerPrefs.SetInt(HIGH_RATING_KEY, highRating2);

        PlayerPrefs.Save();
    }
}
