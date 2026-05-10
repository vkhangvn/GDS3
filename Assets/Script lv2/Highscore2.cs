using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highscore2 : MonoBehaviour
{
    public static int highScore2;
    public static int rating2;

    public endingLV2 endingScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (endingScreen.score > highScore2)
        {
            highScore2 = endingScreen.score;
            rating2 = endingScreen.rating;
        }
    }
}
