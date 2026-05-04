using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    public GameObject waterPrefab;
    public bool haveWater1;
    public int waterNumber;

    public GameObject shaker;
    public GameObject wine;
    public GameObject fluid;
    public int waterLeft;
    public List<GameObject> waterObjects;

    // Start is called before the first frame update
    void Start()
    {
        haveWater1 = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (waterNumber > 250)
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
       
        yield return new WaitForSeconds(4.2f);
        GameObject[] foundWater = GameObject.FindGameObjectsWithTag("Water");
        waterObjects = new List<GameObject>(foundWater);
        foreach (GameObject water in waterObjects)
        {
            waterLeft++;
        }
        wine.SetActive(false);
        shaker.SetActive(shaker);
        Destroy(fluid);
    }
}
