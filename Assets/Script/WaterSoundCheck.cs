using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSoundCheck : MonoBehaviour
{
    private int waterInGlass;
    public GameObject okSound;
    public GameObject goodSound;

    public bool okRun;
    public bool goodRun;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Water"))
        {
            waterInGlass++;
        }
    }

    public void Update()
    {
        if (waterInGlass >= 55 )
        {
            if (okRun)
            {
                StartCoroutine(plusScore());
                okRun = false;
            }
        }

        if (waterInGlass >= 120)
        {
            if (goodRun)
            {
                StartCoroutine(plusScore1());
                goodRun = false;
            }
           
        }
    }

    IEnumerator plusScore()
    {
            okSound.SetActive(true);
            yield return new WaitForSeconds(0.5f);
            okSound.SetActive(false);
            yield return new WaitForSeconds(0.5f);
    }

    IEnumerator plusScore1()
    {
        goodSound.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        goodSound.SetActive(false);
        yield return new WaitForSeconds(0.5f);
    }
}