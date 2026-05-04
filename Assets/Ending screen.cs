using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Endingscreen : MonoBehaviour


{
    public int score;
    public int rating;
    public PointCaculator pointCaculator;

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

            if (pointCaculator.waterInGlass < 50)
        {
            rating = 0;
        }

        if (pointCaculator.waterInGlass < 100 && pointCaculator.waterInGlass > 50 )
        {
            rating = 1;
        }

        if (pointCaculator.waterInGlass < 200 && pointCaculator.waterInGlass > 100)
        {
            rating = 2;
        }

        if (pointCaculator.waterInGlass > 200)
        {
            rating = 3;
        }
        string scoreT = score.ToString();
        string ratingT = rating.ToString();

        scoreText.text = scoreT;
        ratingText.text = ratingT;


    }


}

