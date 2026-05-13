using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public GameObject resumeTimer;
    public Pause pause;
    public GameObject themeSong;

    public GameObject clickSound1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void onTaskClick()
    {
        SceneManager.LoadScene("Wine 1");
    }

    public void tutorialScene()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void exit()
    {
        Application.Quit();
    }

    public void resume()
    {
        pause.pausing = false;
        resumeTimer.SetActive(true);

    }

    public void mainMenuLoad()
    {
        
        SceneManager.LoadScene("Menu");
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            SceneManager.LoadScene("Wine 1");
        }
            
    }

    public void next()
    {
        SceneManager.LoadScene("Level Menu");
    }

    public void Opening()
    {
        StartCoroutine(timerOpening());

    }

    IEnumerator timerOpening()
    {
        themeSong.SetActive(false);
        clickSound1.SetActive(true);
        yield return new WaitForSeconds(0.25f);
        SceneManager.LoadScene("Opening");
    }

}
