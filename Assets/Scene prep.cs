using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sceneprep : MonoBehaviour
{
    public GameObject wine;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.2f);
        wine.SetActive(true);


    }
}
