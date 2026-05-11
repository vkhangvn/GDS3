using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Pourwine : MonoBehaviour
{
    public GameObject waterPrefab;
    public bool haveWater1;
    public int waterNumber;

    public GameObject shaker;
    public GameObject wine;
    public GameObject fluid;
    public int waterLeft;
    public List<GameObject> waterObjects;

    public GameObject shakerContainer;

    public bool continueTutorial;
    public Flowchart mainFlowchart;

    public bool thirdLevel;
    public guideObject guideObject;

    void Start()
    {
        haveWater1 = true;
    }


    void Update()
    {
        if (waterNumber > 300)
        {
            haveWater1 = false;
            StartCoroutine(Timer());
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (haveWater1)
            {
                GameObject newWater = Object.Instantiate(waterPrefab, transform.position, Quaternion.identity, fluid.transform);
                waterNumber++;
            }

        }
    }


    IEnumerator Timer()
    {

        yield return new WaitForSeconds(4f);
        GameObject[] foundWater = GameObject.FindGameObjectsWithTag("Water");
        waterObjects = new List<GameObject>(foundWater);
        foreach (GameObject water in waterObjects)
        {
            waterLeft++;
        }
        shakerContainer.SetActive(false);
        wine.SetActive(false);
        Destroy(fluid);
        guideObject.secondLevel = false;
        thirdLevel = true;
        mainFlowchart.ExecuteBlock("Done second tutorial");
    }
}
