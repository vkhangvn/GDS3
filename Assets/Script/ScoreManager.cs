using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI lv1Text;
    public TextMeshProUGUI lv2Text;
    // Start is called before the first frame update
    void Start()
    {
        bool completed = PlayerPrefs.GetInt("Level2Unlocked", 0) == 1;
        int highScore = PlayerPrefs.GetInt("HighScore", 0);
        int highScore2 = PlayerPrefs.GetInt("highScore2", 0);
        lv1Text.text = string.Format("{0}", HighScore.highScore);
        lv2Text.text = string.Format("{0}", LV2highscore.highScore2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
