using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class transitionTime : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    public float timeRemain;
    public bool fail;

    public GameObject transitionTimer;

    public GameObject scenePrep;

    public bool wine;
    public bool shaker;
    public bool shakerDrop;

    public GameObject wineTutorial;
    public GameObject shakerTutorial;

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

        if (shaker)
        {
            shaker = false;
            StartCoroutine(Tutorial2());

        }

        if (shakerDrop)
        {
            shakerDrop = false;
            StartCoroutine(Tutorial1());

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
       
        yield return new WaitForSeconds(0.1f);
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
            shakerTutorial.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            shakerTutorial.SetActive(false);
            yield return new WaitForSeconds(0.5f);
        }

        shakerTutorial.SetActive(false);

    }
}
