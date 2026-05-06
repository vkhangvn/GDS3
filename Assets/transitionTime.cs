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

    public GameObject gameTimer;

    public GameObject scenePrep;

    // Start is called before the first frame update
    void Start()
    {
        timeRemain = 3f;
    }

    // Update is called once per frame
    void Update()
    {
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
        gameTimer.SetActive(true);
        scenePrep.SetActive(true);
        timeRemain = 3f;
        transitionTimer.SetActive(false);
    }
}
