using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class wineDropTutorial : MonoBehaviour
{
    public int waterLeft;
    public int waterNumber;
    public Pourwine pourWine;

    public GameObject shaker1;
    public bool haveWater2;
    public bool completed;

    public GameObject waterPrefab;

    public Flowchart mainFlowchart;

    // Start is called before the first frame update
    void Start()
    {
        haveWater2 = true;
        waterLeft = pourWine.waterLeft;
    }

    // Update is called once per frame
    void Update()
    {
      

            if (waterNumber == waterLeft)
            {

                haveWater2 = false;
                mainFlowchart.ExecuteBlock("tutorial complete");
        }

            if (Input.GetKey(KeyCode.Mouse0))
            {
                if (haveWater2)
                {
                    GameObject newWater = Object.Instantiate(waterPrefab, transform.position, Quaternion.identity);
                    waterNumber++;

                }

            }
        }
    
}
