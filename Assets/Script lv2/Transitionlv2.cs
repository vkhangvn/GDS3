using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Transitionlv2 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    public float timeRemain;
    public bool fail;

    public GameObject transitionTimer;

    public GameObject gameTimer;

    public GameObject scenePrep;

    public bool wine;
    public bool ice;
    public bool spice;

    public GameObject wineTutorial;
    public GameObject iceTutorial;

    // Start is called before the first frame update
    void Start()
    {
        timeRemain = 3f;
    }

    // Update is called once per frame
    void Update()
    {
        if (wine)
        {
            wine = false;
            StartCoroutine(Tutorial1());

        }

        if (ice)
        {
            ice = false;
            StartCoroutine(Tutorial2());

        }

        if (spice)
        {
            spice = false;
            StartCoroutine(Tutorial3());

        }


        if (timeRemain > 0)
        {
            timeRemain -= Time.deltaTime;

        }

        if (timeRemain < 0)
        {
            timeRemain = 0f;
        }

        if (timeRemain == 0)
        {
            StartCoroutine(Timer());
        }

        int seconds = Mathf.FloorToInt(timeRemain % 60);

        timerText.text = string.Format("{0}", seconds);
    }

    IEnumerator Timer()
    {
        Debug.Log("running");
        yield return new WaitForSeconds(0.1f);
        gameTimer.SetActive(true);
        scenePrep.SetActive(true);
        timeRemain = 3f;
        transitionTimer.SetActive(false);
    }

    IEnumerator Tutorial1()
    {
        for (int i = 0; i < 3; i++)
        {
            wineTutorial.SetActive(true);
            yield return new WaitForSeconds(0.501f);
            wineTutorial.SetActive(false);
            yield return new WaitForSeconds(0.501f);

        }

        wineTutorial.SetActive(false);


    }

    IEnumerator Tutorial2()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int e = 0; i < 2; e++)
            {
                iceTutorial.SetActive(true);
                yield return new WaitForSeconds(0.5f);
                iceTutorial.SetActive(false);
                yield return new WaitForSeconds(0.5f);
            }

            wineTutorial.SetActive(true);
            yield return new WaitForSeconds(0.501f);
            wineTutorial.SetActive(false);
            yield return new WaitForSeconds(0.501f);
            wineTutorial.SetActive(true);
            yield return new WaitForSeconds(0.501f);
            wineTutorial.SetActive(false);
            yield return new WaitForSeconds(0.501f);
            wineTutorial.SetActive(true);
            yield return new WaitForSeconds(0.501f);
            wineTutorial.SetActive(false);
            yield return new WaitForSeconds(0.501f);
        }

        wineTutorial.SetActive(false);
        iceTutorial.SetActive(false);

    }

    IEnumerator Tutorial3()
    {
        for (int i = 0; i < 3; i++)
        {
            wineTutorial.SetActive(true);
            yield return new WaitForSeconds(0.501f);
            wineTutorial.SetActive(false);
            yield return new WaitForSeconds(0.501f);

        }

        wineTutorial.SetActive(false);
        transitionTimer.SetActive(false);

    }
}
