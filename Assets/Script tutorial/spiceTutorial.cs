using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class spiceTutorial : MonoBehaviour
{

    public GameObject spicePrefab;

    public GameObject spice;

    public Flowchart mainFlowchart;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.Mouse0))
        {

                GameObject newWater = Object.Instantiate(spicePrefab, transform.position, Quaternion.identity);


        }
    }


    IEnumerator Timer()
    {
        yield return new WaitForSeconds(6f);
        mainFlowchart.ExecuteBlock("spice completed");

    }
}