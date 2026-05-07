using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pauseTimer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    public float timeRemain;

    public GameObject pauseTime;

    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (timeRemain > 0)
        {
            
            timeRemain -= Time.unscaledDeltaTime;
            pauseMenu.SetActive(false);
        }

        if (timeRemain < 0)
        {
            timeRemain = 0f;
        }

        if (timeRemain == 0)
        {
            pauseTime.SetActive(false);
            Time.timeScale = 1;
            
        }
        int seconds = Mathf.FloorToInt(timeRemain % 60);

        timerText.text = string.Format("{0}", seconds);

    }
}
