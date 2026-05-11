using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ice2 : MonoBehaviour
{
    //public static int iceCount;
    public bool following2;
    public GameObject toolTips;

    // Update is called once per frame

    void Update()
    {
        if (following2)
        {
            transform.position = toolTips.transform.position;
        }
    }

}
