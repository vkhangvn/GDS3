using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class endingLV2 : MonoBehaviour

{
    public int score;
    public int rating;
    public float time;
    public pointCheckLv2 pointCheckLv2;
    public Timer2 timer2;

    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI ratingText;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        score = (pointCheckLv2.waterInGlass * 6) + (pointCheckLv2.spiceInGlass * 3) + (pointCheckLv2.iceInGlass * 5);
        time = timer2.timeRemain;

        Debug.Log(time);

        if (score < 300 && time < 60 && time > 0)
        {
            rating = 0;
        }

        if (score < 700 && score >= 300 && time >= 60)
        {
            rating = 1;
        }

        if (score < 1700 && score >= 700 && time >= 90)
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
