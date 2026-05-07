using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaker : MonoBehaviour
{
    public int score;

    public GameObject shaker;

    public GameObject shakerDrop;
    public GameObject glass;

    public bool level3;
    public GameObject prepControl;

    public GameObject scoring1;
    public GameObject scoring2;
    public GameObject scoring3;
    public int randomScore;

    public GameObject pointAudio;

    public GameObject transitionTimer;
    public transitionTime transitionTime;

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(Timer());
        glass.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Vector3 velocity = rb.velocity;
        float speed = rb.velocity.magnitude;
        

        if (speed > 95f || speed < -95f)
        {
            StartCoroutine(plusScore());
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(10f);

        transitionTimer.SetActive(true);
        glass.SetActive(true);
        transitionTime.shakerDrop = true;
        level3 = true;
        scoring1.SetActive(false);
        scoring2.SetActive(false);
        scoring3.SetActive(false);
        shaker.SetActive(false);
    }

    IEnumerator plusScore()
    {
        randomScore = Random.Range(1, 3);
        pointAudio.SetActive(true);
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
        pointAudio.SetActive(false);
    }
}

