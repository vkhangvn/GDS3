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
        score = pointCaculator.waterInGlass + shaker.score;
        time = timer.timeRemain;

            if (pointCaculator.waterInGlass < 31 )
        {
            rating = 0;
        }

        if (pointCaculator.waterInGlass < 101 && pointCaculator.waterInGlass > 30f)
        {
            rating = 1;
        }

        if (pointCaculator.waterInGlass < 141 && pointCaculator.waterInGlass > 100)
        {
            rating = 2;
        }

        if (pointCaculator.waterInGlass > 140)
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

