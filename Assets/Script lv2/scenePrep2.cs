using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scenePrep2 : MonoBehaviour
{
    public bool icePrep;
    public bool winePrep;
    public bool spicePrep;

    public GameObject ice;
    public GameObject wine;
    public GameObject spice;


    public GameObject prepControl;
    public Transform startPosition;

    public GameObject iceCube;

    public GameObject wineSample;
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

        else if (icePrep)
        {

            StartCoroutine(Timer2());
        }

        else if (spicePrep)

        {
            StartCoroutine(Timer3());
        }

    }

    IEnumerator Timer1()
    {
        
        yield return new WaitForSeconds(0.3f);
        wineSample.SetActive(false);
        wine.SetActive(true);
        winePrep = false;
        icePrep = true;
        prepControl.SetActive(false);
    }

    IEnumerator Timer2()
    {
        yield return new WaitForSeconds(0.3f);
        ice.SetActive(true);
        iceCube.SetActive(true);
        icePrep = false;
        spicePrep = true;
        prepControl.SetActive(false);
    }

    IEnumerator Timer3()
    {
        spice.transform.position = startPosition.position;
        yield return new WaitForSeconds(0.3f);
        spice.SetActive(true);
        spicePrep = false;
        prepControl.SetActive(false);
    }


}
