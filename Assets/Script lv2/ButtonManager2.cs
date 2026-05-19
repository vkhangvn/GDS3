using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager2 : MonoBehaviour
{
    public GameObject resumeTimer;
    public Pause pause;

    public void retry()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Wine 2");
    }

    public void next()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level Menu");
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene("Wine 2");
        }

    }

    public void resume()
    {
        Time.timeScale = 1;
        pause.pausing = false;
        resumeTimer.SetActive(true);
    }
}
