using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedLV2 : MonoBehaviour
{
    public GameObject unlocked;
    public GameObject locked;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (WaterManager.level1Completed)
        {
            locked.SetActive(false);
            unlocked.SetActive(true);
        }
    }
}
