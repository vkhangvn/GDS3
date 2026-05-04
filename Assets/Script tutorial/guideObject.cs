using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class guideObject : MonoBehaviour
{
    public Flowchart mainFlowchart;
    public bool firstLevel;
    public bool secondLevel;



    // Start is called before the first frame update
    void Start()
    {
        firstLevel = true;
    }

    // Update is called once per frame
    public void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            firstLevel = false;
            secondLevel = true;
            mainFlowchart.ExecuteBlock("Done first tutorial");

        }
    }
}
