using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallLV2 : MonoBehaviour
{
    public GameObject breakSound;
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
        breakSound.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene("Fail menu 2");
    }
}