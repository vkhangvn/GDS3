using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Fungus;

public class endingLV2 : MonoBehaviour

{
    public int score;
    public int rating;
    public float time;
    public pointCheckLv2 pointCheckLv2;
    public Timer2 timer2;


    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI ratingText;

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


    public Flowchart mainFlowchart;

    public int random;

    public bool randomOnce;


    // Start is called before the first frame update
    void Start()
    {
        randomOnce = true;
        Cursor.visible = true;
        gameHand.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        score = (pointCheckLv2.waterInGlass * 8) + (pointCheckLv2.spiceInGlass * 2) + (pointCheckLv2.iceInGlass * 8);
        time = timer2.timeRemain;

        Debug.Log(time);

        if (score < 300 && time < 30 && time > 0)
        {
            oneStarDrink.SetActive(true);
            vampire1.SetActive(true);
            rating = 0;

            if (randomOnce)
            {
                randomOnce = false;
                random = Random.Range(1, 5);
                if (random == 1)
                {
                    mainFlowchart.ExecuteBlock("Bad feedback 1");
                }
                if (random == 2)
                {
                    mainFlowchart.ExecuteBlock("Bad feedback 2");
                }
                if (random == 3)
                {
                    mainFlowchart.ExecuteBlock("Bad feedback 3");
                }
                if (random == 4)
                {
                    mainFlowchart.ExecuteBlock("Bad feedback 4");
                }
            }
        }

        if (score < 700 && score >= 300 && time >= 30)
        {
            oneStarDrink.SetActive(true);
            vampire1.SetActive(true);
            star1.SetActive(true);
            rating = 1;

            if (randomOnce)
            {
                randomOnce = false;
                random = Random.Range(1, 5);
                if (random == 1)
                {
                    mainFlowchart.ExecuteBlock("Bad feedback 1");
                }
                if (random == 2)
                {
                    mainFlowchart.ExecuteBlock("Bad feedback 2");
                }
                if (random == 3)
                {
                    mainFlowchart.ExecuteBlock("Bad feedback 3");
                }
                if (random == 4)
                {
                    mainFlowchart.ExecuteBlock("Bad feedback 4");
                }
            }
        }

        if (score < 1700 && score >= 700 && time >= 40)
        {
            twoStarDrink.SetActive(true);
            vampire2.SetActive(true);
            star1.SetActive(true);
            star2.SetActive(true);
            rating = 2;

            if (randomOnce)
            {
                randomOnce = false;
                random = Random.Range(1, 5);
                if (random == 1)
                {
                    mainFlowchart.ExecuteBlock("Ok feedback 1");
                }
                if (random == 2)
                {
                    mainFlowchart.ExecuteBlock("Ok feedback 2");
                }
                if (random == 3)
                {
                    mainFlowchart.ExecuteBlock("Ok feedback 3");
                }
                if (random == 4)
                {
                    mainFlowchart.ExecuteBlock("Ok feedback 4");
                }
            }
        }

        if (score >= 1700 && time >= 50)
        {
            threeStarDrink.SetActive(true);
            vampire3.SetActive(true);
            star1.SetActive(true);
            star2.SetActive(true);
            star3.SetActive(true);
            rating = 3;

            if (randomOnce)
            { 
                random = Random.Range(1, 6);
                if (random == 1)
                {
                    mainFlowchart.ExecuteBlock("Good feedback 1");
                }
                if (random == 2)
                {
                    mainFlowchart.ExecuteBlock("Good feedback 2");
                }
                if (random == 3)
                {
                    mainFlowchart.ExecuteBlock("Good feedback 3");
                }
                if (random == 4)
                {
                    mainFlowchart.ExecuteBlock("Good feedback 4");
                }
                if (random == 5)
                {
                    mainFlowchart.ExecuteBlock("Good feedback 5");
                }
            }
        }
        string scoreT = score.ToString();
        scoreText.text = scoreT;

        // 3star = 50s
        // 2star = 40s
        // 1star = 30s
    }


}
