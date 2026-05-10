using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager2 : MonoBehaviour
{
    public void retry()
    {
        SceneManager.LoadScene("Wine 2");
    }

    public void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            SceneManager.LoadScene("Wine 2");
        }

    }
}
