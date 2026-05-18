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

    public GameObject hit1;
    public GameObject hit2;

    public GameObject dialogueCheck2;

    public GameObject arrow1;
    public GameObject arrow2;
    public GameObject arrow1Light;
    public GameObject arrow2Light;
    [SerializeField] private Animator shakerOpened;
    public bool pouring;

    public GameObject shakeSound;

    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
        glass.SetActive(false);
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Trigger1"))
        {
            StartCoroutine(trigger1());
            hit1.SetActive(false);
            hit2.SetActive(true);
            StartCoroutine(plusScore());
        }

        if (other.CompareTag("Trigger2"))
        {
            StartCoroutine(trigger2());
            hit2.SetActive(false);
            hit1.SetActive(true);
            StartCoroutine(plusScore());
        }

    
    }

    public void Update()
    {
  
        if (rb.velocity.magnitude > 0.1f)
        {
            shakeSound.SetActive(true);    
        }

        else
        {
            shakeSound.SetActive(false);
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(10f);
        dialogueCheck2.SetActive(true);
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


    IEnumerator trigger1()
    {
        arrow2Light.SetActive(true);
        arrow2.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        arrow2Light.SetActive(false);
        arrow1.SetActive(true);
    }


    IEnumerator trigger2()
    {
        arrow1Light.SetActive(true);
        arrow1.SetActive(false);
        yield return new WaitForSeconds(0.5f);
        arrow1Light.SetActive(false);
        arrow2.SetActive(true);
    }
}



// 300 goodfeeback
// 200 nice
//100 ok
//<100 bad