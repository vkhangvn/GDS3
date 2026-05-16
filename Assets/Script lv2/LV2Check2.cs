using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LV2Check2 : MonoBehaviour
{
    public pointCheckLv2 pointCheck;

    public GameObject vampireHappy;
    public GameObject vampireNeutral;
    public GameObject vampireAngry;

    public GameObject check2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pointCheck.iceInGlass >= 0 && pointCheck.iceInGlass <= 1)
        {
            vampireNeutral.SetActive(false);
            vampireHappy.SetActive(false);
            vampireAngry.SetActive(true);
            check2.SetActive(false);

        }
        if (pointCheck.iceInGlass > 1 && pointCheck.iceInGlass <= 2)
        {
            vampireNeutral.SetActive(true);
            vampireHappy.SetActive(false);
            vampireAngry.SetActive(false);
            check2.SetActive(false);

        }

        if (pointCheck.iceInGlass > 2)
        {
            vampireNeutral.SetActive(false);
            vampireHappy.SetActive(true);
            vampireAngry.SetActive(false);
            check2.SetActive(false);

        }

    }
}
