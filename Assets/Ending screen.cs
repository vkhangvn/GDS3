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

    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI ratingText;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        score = pointCaculator.waterInGlass;
        time = timer.timeRemain;

            if (pointCaculator.waterInGlass < 50 )
        {
            rating = 0;
        }

        if ((pointCaculator.waterInGlass < 100 && pointCaculator.waterInGlass > 50f) && timer.timeRemain < 70f)
        {
            rating = 1;
        }

        if ((pointCaculator.waterInGlass < 200 && pointCaculator.waterInGlass > 100) && (timer.timeRemain > 70f && timer.timeRemain < 120f))
        {
            rating = 2;
        }

        if (pointCaculator.waterInGlass > 200 && timer.timeRemain > 120f)
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

