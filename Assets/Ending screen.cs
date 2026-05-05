using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Endingscreen : MonoBehaviour


{
    public int score;
    public int rating;
    public float time;
    public PointCaculator pointCaculator;
    public Timer timer;
    public Shaker shaker;

    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI ratingText;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        score = (pointCaculator.waterInGlass * 4) + shaker.score;
        time = timer.timeRemain;

        Debug.Log(time);

        if (score < 300 && time < 60 && time > 0)
        {
            rating = 0;
        }

        if (score < 700 && score >= 300 && time >= 60 )
        {
            rating = 1;
        }

        if (score < 1400 && score >= 700 && time >= 90 )
        {
            rating = 2;
        }

        if (score >= 1700 && time >= 120)
        {
            rating = 3;
        }
        string scoreT = score.ToString();
        string ratingT = rating.ToString();

        scoreText.text = scoreT;
        ratingText.text = ratingT;

        // 3star = 120s
        // 2star = 90-120s
        // 1star = <90s
    }


}

