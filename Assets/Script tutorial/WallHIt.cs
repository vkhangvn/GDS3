using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class WallHIt : MonoBehaviour
{

    public Flowchart mainFlowchart;

    public Transform startPosition;

    public guideObject guideObject;

    public Pourwine pourWine;

    public TurorialShake tutorialShake;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    public void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            if (guideObject.firstLevel)
            {
                transform.position = startPosition.position;
                mainFlowchart.ExecuteBlock("1st Broke");
            }

            if (guideObject.secondLevel)
            {
                transform.position = startPosition.position;
                mainFlowchart.ExecuteBlock("2nd Broke");
            }

            if (pourWine.thirdLevel)
            {
                transform.position = startPosition.position;
                mainFlowchart.ExecuteBlock("3rd Broke");
            }


            if (tutorialShake.finalLevel)
            {
                transform.position = startPosition.position;
                mainFlowchart.ExecuteBlock("final Broke");
            }


        }


    }
}
