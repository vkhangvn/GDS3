using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Broken2 : MonoBehaviour
{
    public GameObject brokenWine;
    public GameObject winesprite;
    public GameObject breakSound;
    public Transform winePos;
    public Transform brokenBottle;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Timer());
        }
    }

    IEnumerator Timer()
    {
        brokenBottle.position = winePos.position;
        brokenWine.SetActive(true);
        winesprite.SetActive(false);

        breakSound.SetActive(true);
        yield return new WaitForSeconds(0.9f);
        SceneManager.LoadScene("Fail menu 2");
    }
}

