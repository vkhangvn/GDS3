using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelButtonManager : MonoBehaviour
{
    public GameObject level1Screen;
    public GameObject level2Screen;

    public GameObject setting;

    public GameObject tutorial1;
    public GameObject tutorial2;
    public GameObject tutorial3;

    public GameObject tutorial2_1;
    public GameObject tutorial2_2;
    public GameObject tutorial2_3;

    public Toggle toggle;
    // Start is called before the first frame update
    public void Level1Start()
    {
        SceneManager.LoadScene("Wine 1");
    }

    public void Level2Start()
    {
        SceneManager.LoadScene("Wine 2");
    }

    public void Page1()
    {
        level2Screen.SetActive(false);
        level1Screen.SetActive(true);
    }

    public void Page2()
    {
        level2Screen.SetActive(true);
        level1Screen.SetActive(false);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    private void Update()
    {
           if( Input.GetKey(KeyCode.Escape))
        {
            setting.SetActive(true);
        }
    }


    public void wineTutorial()
    {
        tutorial2.SetActive(false);
        tutorial1.SetActive(true);
    }

    public void shakerTutorial()
    {
        tutorial2.SetActive(true);
        tutorial1.SetActive(false);
        tutorial3.SetActive(false);
    }

    public void shakerDropTutorial()
    {
        tutorial2.SetActive(false);
        tutorial3.SetActive(true);
    }

    public void tutorialPopUp()
    {
        level1Screen.SetActive(false);
        level2Screen.SetActive(false);
        tutorial1.SetActive(true);
    }

    public void closeTutorial2()
    {
        tutorial1.SetActive(false);
        tutorial2.SetActive(false);
        tutorial3.SetActive(false);
        tutorial2_1.SetActive(false);
        tutorial2_2.SetActive(false);
        tutorial2_3.SetActive(false);
        level1Screen.SetActive(true);
        if (WaterManager.level1Completed)
        {
            level2Screen.SetActive(true);
        }
    }


    public void closeSetting()
    {
        setting.SetActive(false);
    }

    public void nextPage1()
    {
        tutorial2_2.SetActive(true);
        tutorial2_1.SetActive(false);
    }

    public void nextPage2()
    {
        tutorial2_3.SetActive(true);
        tutorial2_2.SetActive(false);
        tutorial2_1.SetActive(false);
    }

    public void previousPage1()
    {
        tutorial2_3.SetActive(false);
        tutorial2_2.SetActive(false);
        tutorial2_1.SetActive(true);
    }

    public void tutorialPopUp2()
    {
        level1Screen.SetActive(false);
        level2Screen.SetActive(false);
        tutorial2_1.SetActive(true);
    }

    public void Toggle()
    {
        toggle.onValueChanged.AddListener(delegate { toggleChangeCheck(); });
    }

    public void toggleChangeCheck()
    {
        if (toggle.isOn)
        {
            WaterManager.level1Completed = true;
        }

        if (!toggle.isOn)
        {
            WaterManager.level1Completed = false;
        }
    }
}
