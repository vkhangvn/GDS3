using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class TurorialShake : MonoBehaviour
{
    public Flowchart mainFlowchart;
    public Pourwine pourWine;
    public bool finalLevel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        
        yield return new WaitForSeconds(10f);
        pourWine.thirdLevel = false;
        finalLevel = true;
        mainFlowchart.ExecuteBlock("Done third tutorial");
    }
}
