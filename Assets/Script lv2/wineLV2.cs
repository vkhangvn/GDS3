using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wineLV2 : MonoBehaviour
{
    public GameObject waterPrefab;
    public bool haveWater1;
    public int waterNumber;

    public GameObject wine;
    public GameObject fluid;
    public int waterLeft;
    public List<GameObject> waterObjects;

    public GameObject shakerContainer;

    public GameObject prepControl;
    public GameObject wineAudio;

    public GameObject transitionTimer;
    public Transitionlv2 transitionLV2;

    public GameObject iceContainer;
    public GameObject ice;

    public GameObject check1;
    // Start is called before the first frame update
    void Start()
    {
        haveWater1 = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (waterNumber > 180)
        {
            haveWater1 = false;
            StartCoroutine(Timer());
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (haveWater1)
            {
                wineAudio.SetActive(true);
                GameObject newWater = Object.Instantiate(waterPrefab, transform.position, Quaternion.identity, fluid.transform);
                waterNumber++;
            }

        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            wineAudio.SetActive(false);
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
        check1.SetActive(true);
        ice.SetActive(true);
        transitionLV2.ice = true;
        iceContainer.SetActive(true);
        transitionTimer.SetActive(true);
        wine.SetActive(false);
        
    }
}

