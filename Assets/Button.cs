using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
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
}
