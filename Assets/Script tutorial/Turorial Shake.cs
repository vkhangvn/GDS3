using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class TurorialShake : MonoBehaviour
{
    public Flowchart mainFlowchart;
    public Pourwine pourWine;
    public bool finalLevel;
    public GameObject scoring1;
    public GameObject scoring2;
    public GameObject scoring3;
    public int randomScore;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            Vector3 velocity = rb.velocity;
            float speed = rb.velocity.magnitude;


            if (speed > 40f || speed < -40f)
            {
                StartCoroutine(plusScore());

            }
        }
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        
        yield return new WaitForSeconds(10f);
        pourWine.thirdLevel = false;
        finalLevel = true;
        scoring1.SetActive(false);
        scoring2.SetActive(false);
        scoring3.SetActive(false);
        mainFlowchart.ExecuteBlock("Done third tutorial");
    }

    IEnumerator plusScore()
    {
        randomScore = Random.Range(1, 3);
            if (randomScore == 1)
        {
            scoring1.SetActive(true);
        }

        if (randomScore == 2)
        {
            scoring2.SetActive(true);
        }

        if (randomScore == 3)
        {
            scoring3.SetActive(true);
        }

        score++;

        yield return new WaitForSeconds(1.3f);
        scoring1.SetActive(false);
        scoring2.SetActive(false);
        scoring3.SetActive(false);
    }
}
