using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject transitionTimer;
    public GameObject pauseMenu;
    public bool pausing;

    public pauseTimer pauseTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            if(transitionTimer.activeInHierarchy == false)
            {
                if (pausing == false)
                {
                    pauseMenu.SetActive(true);
                    Debug.Log("a");
                    pauseTimer.timeRemain = 3;
                    Time.timeScale = 0;
                    pausing = true;
                   
                }

            }
        }
    }
}
