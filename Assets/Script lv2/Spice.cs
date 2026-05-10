using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spice : MonoBehaviour
{
    public bool completed;
    public GameObject spicePrefab;

    public GameObject spice;
    public GameObject pointCheck;
    public GameObject transitionTimer;

    public GameObject endingScreen;
    public GameObject fluid;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
        Destroy(transitionTimer);
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.Mouse0))
        {

            if (!completed)
            {
                GameObject newWater = Object.Instantiate(spicePrefab, transform.position, Quaternion.identity, fluid.transform);

            }

        }
    }


    IEnumerator Timer()
    {
        yield return new WaitForSeconds(10f);
        completed = true;
        pointCheck.SetActive(true);
        spice.SetActive(false);
        endingScreen.SetActive(true);



    }
}
