using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LV2highscore : MonoBehaviour
{
    public static int highScore2;
    public static int highRating2;

    public endingLV2 endingScreen2;

    // Update is called once per frame
    void Update()
    {
        if (endingScreen2.score > highScore2)
        {
            highScore2 = endingScreen2.score;
            highRating2 = endingScreen2.rating;

            PlayerPrefs.SetInt("HighScore2", highScore2);
            PlayerPrefs.SetInt("highRating2", highRating2);
            PlayerPrefs.Save();
        }
    }
}

