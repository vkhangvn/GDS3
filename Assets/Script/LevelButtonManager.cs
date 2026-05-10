using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButtonManager : MonoBehaviour
{
    public GameObject level1Screen;
    public GameObject level2Screen;
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
}
