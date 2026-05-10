using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("highScoreLV1", HighScore.highScore);
        PlayerPrefs.SetInt("highScoreLV2", LV2highscore.highScore2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
