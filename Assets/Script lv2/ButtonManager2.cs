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
        SceneManager.LoadScene("Wine 2");
    }

    public void next()
    {
        SceneManager.LoadScene("Level Menu");
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            SceneManager.LoadScene("Wine 2");
        }


    }

    public void resume()
    {
        pause.pausing = false;
        resumeTimer.SetActive(true);
    }
}
