using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Sceneprep : MonoBehaviour
{
    public bool winePrep;
    public bool shakerDropPrep;
    public GameObject wine;
    public GameObject shaker;
    public bool shakerPrep;
    public GameObject shakerDrop;

    public GameObject prepControl;

    public Transform startPosition;

    public GameObject wineTutorial;
    public GameObject shakerTutorial;

    public GameObject sampleWine;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       

            if (winePrep)
            {

            StartCoroutine(Timer1());
            }

            else if (shakerPrep)
            {

            StartCoroutine(Timer2());
            }

            else if (shakerDropPrep)

            {

            StartCoroutine(Timer3());
            }

    }

    IEnumerator Timer1()
    {
        wine.transform.position = startPosition.position;
        yield return new WaitForSeconds(0.3f);
        wine.SetActive(true);
        winePrep = false;
        shakerPrep = true;
        prepControl.SetActive(false);
        sampleWine.SetActive(false);
    }

    IEnumerator Timer2()
    {
        shaker.transform.position = startPosition.position;
        yield return new WaitForSeconds(0.3f);
        shaker.SetActive(true);
        shakerPrep = false;
        shakerDropPrep = true;
        prepControl.SetActive(false);
    }

    IEnumerator Timer3()
    {
        shakerDrop.transform.position = startPosition.position;
        yield return new WaitForSeconds(0.3f);
        shakerDrop.SetActive(true);
        shakerDropPrep = false;
        prepControl.SetActive(false);
    }


}
