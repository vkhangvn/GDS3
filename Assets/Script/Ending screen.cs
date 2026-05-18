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
    public GameObject gameHand;

    public GameObject star1;
    public GameObject star2;
    public GameObject star3;

    public GameObject vampire1;
    public GameObject vampire2;
    public GameObject vampire3;

    public GameObject oneStarDrink;
    public GameObject twoStarDrink;
    public GameObject threeStarDrink;

    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI ratingText;

    // Start is called before the first frame update
    void Start()
    {
        gameHand.SetActive(false);
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        score = (pointCaculator.waterInGlass * 8) + (shaker.score *4);
        time = timer.timeRemain;

        Debug.Log(time);

        if (score < 300 && time < 60 && time > 0)
        {
            oneStarDrink.SetActive(true);
            vampire1.SetActive(true);
            rating = 0;
        }

        if (score < 700 && score >= 300 && time >= 60 )
        {
            oneStarDrink.SetActive(true);
            vampire1.SetActive(true);
            star1.SetActive(true);
            rating = 1;
        }

        if (score < 1250 && score >= 700 && time >= 90 )
        {
            twoStarDrink.SetActive(true);
            vampire2.SetActive(true);
            star1.SetActive(true);
            star2.SetActive(true);
            rating = 2;
        }

        if (score >= 1250 && time >= 120)
        {
            threeStarDrink.SetActive(true);
            vampire3.SetActive(true);
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            rating = 3;
        }
        string scoreT = score.ToString();
        string ratingT = rating.ToString();

        scoreText.text = scoreT;

        // 3star = 120s
        // 2star = 90-120s
        // 1star = <90s
    }


}

