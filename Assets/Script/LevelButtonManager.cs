using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButtonManager : MonoBehaviour
{
    public GameObject level1Screen;
    public GameObject level2Screen;

    public GameObject setting;

    public GameObject tutorial1;
    public GameObject tutorial2;
    public GameObject tutorial3;
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
}
