using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField]  float timeRemain;
    public bool fail;

    // Start is called before the first frame update
    void Start()
    {
        
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
            fail = true;
            Debug.Log("fail");
        }
        int minutes = Mathf.FloorToInt(timeRemain / 60);
        int seconds = Mathf.FloorToInt(timeRemain % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

       
    }
}
