using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer2 : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    public float timeRemain;
    public bool fail;
    public Spice spice;

    // Start is called before the first frame update
    void Start()
    {
        timeRemain = 110f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemain > 0 && spice.completed == false)
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
