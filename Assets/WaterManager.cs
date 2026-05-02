using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterManager : MonoBehaviour
{
    
    public int waterLeft;
    public int waterNumber;
    public bool level3;
    public Slime slime;
    public Shaker shaker;

    public GameObject shaker1;
    public bool haveWater2;

    public GameObject waterPrefab;
    // Start is called before the first frame update
    void Start()
    {
        haveWater2 = true;
        waterLeft = slime.waterLeft;
        level3 = shaker.level3;
    }

    // Update is called once per frame
    void Update()
    {
        if (level3)
        {

            if (waterNumber == waterLeft)
            {
                haveWater2 = false;
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
}
