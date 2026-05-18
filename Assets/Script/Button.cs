using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    public GameObject resumeTimer;
    public Pause pause;
    public GameObject themeSong;

    public GameObject clickSound1;
    public GameObject setting;

    public Slider volumeLimitSlider;

    public static float volume;

    public GameObject settingSound;
    public GameObject creditSound;

    public Toggle toggle;

    public static bool openingPlayed;
    // Start is called before the first frame update
    void Start()
    {
        openingPlayed = true;
    }

    // Update is called once per frame
    public void onTaskClick()
    {
        Time.timeScale = 1;
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
            Time.timeScale = 1;
            SceneManager.LoadScene("Wine 1");
        }
            
    }

    public void next()
    {
        SceneManager.LoadScene("Level Menu");
    }

    public void Opening()
    {
        if (openingPlayed == true)
        {
            openingPlayed = true;
            StartCoroutine(timerOpening());
        }
        if (openingPlayed == false)
        {
            StartCoroutine(timerStart());
        }

    }

    public void SettingOpen()
    {
        StartCoroutine(settingOpening());

    }

    public void SettingExit()
    {
        StartCoroutine(settingexit());
    }

    IEnumerator timerOpening()
    {
        themeSong.SetActive(false);
        clickSound1.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        SceneManager.LoadScene("Opening");
    }

    IEnumerator settingOpening()
    {
        settingSound.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        setting.SetActive(true);
        settingSound.SetActive(false);
    }

    IEnumerator settingexit()
    {
        yield return new WaitForSeconds(0.4f);
        setting.SetActive(false);

    }

    public void setVolumeLimit()
    {
        volumeLimitSlider.onValueChanged.AddListener(delegate { volumeChangeCheck(); });
    }

    public void volumeChangeCheck()
    {
        volume = volumeLimitSlider.value;
        AudioListener.volume = volume;
    }

    public void GameExit()
    {
        Application.Quit();
    }

    public void Toggle()
    {
        toggle.onValueChanged.AddListener(delegate { toggleChangeCheck(); });
    }

    public void toggleChangeCheck()
    {
        if(toggle.isOn)
        {
            WaterManager.level1Completed = true;
        }

        if (!toggle.isOn)
        {
            WaterManager.level1Completed = false;
        }
    }

    IEnumerator timerStart()
    {
        themeSong.SetActive(false);
        clickSound1.SetActive(true);
        yield return new WaitForSeconds(0.4f);
        SceneManager.LoadScene("Level Menu");
    }
}
