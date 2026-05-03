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
        if (waterNumber > 400)
        {
            haveWater1 = false;
            StartCoroutine(Timer());
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (haveWater1)
            { 
                GameObject newWater = Object.Instantiate(waterPrefab, transform.position, Quaternion.identity,wine.transform);
                waterNumber++;
            }

        }
    }


    IEnumerator Timer()
    {
       
        yield return new WaitForSeconds(3f);
        GameObject[] foundWater = GameObject.FindGameObjectsWithTag("Water");
        waterObjects = new List<GameObject>(foundWater);
        foreach (GameObject water in waterObjects)
        {
            waterLeft++;
        }
        wine.SetActive(false);
        shaker.SetActive(shaker);
    }
}
