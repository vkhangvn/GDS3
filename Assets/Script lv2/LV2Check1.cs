using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LV2Check1 : MonoBehaviour
{
    public pointCheckLv2 pointCheck;

    public GameObject vampireHappy;
    public GameObject vampireNeutral;
    public GameObject vampireAngry;

    public GameObject check1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (pointCheck.waterInGlass >= 0 && pointCheck.waterInGlass <= 50)
        {
            vampireNeutral.SetActive(false);
            vampireHappy.SetActive(false);
            vampireAngry.SetActive(true);
            check1.SetActive(false);

        }
        if (pointCheck.waterInGlass > 50 && pointCheck.waterInGlass <= 100)
        {
            vampireNeutral.SetActive(true);
            vampireHappy.SetActive(false);
            vampireAngry.SetActive(false);
            check1.SetActive(false);

        }

        if (pointCheck.waterInGlass > 100)
        {
            vampireNeutral.SetActive(false);
            vampireHappy.SetActive(true);
            vampireAngry.SetActive(false);
            check1.SetActive(false);

        }

    }
}
