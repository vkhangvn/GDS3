using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TongBreak : MonoBehaviour
{
    public GameObject breakSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Tong"))
        {
            StartCoroutine(Timer());
        }
    }

    IEnumerator Timer()
    { 
        breakSound.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Fail menu 2");
    }
}
