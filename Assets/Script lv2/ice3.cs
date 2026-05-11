using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ice3 : MonoBehaviour
{
    //public static int iceCount;
    public bool following3;
    public GameObject toolTips;

    // Update is called once per frame

    void Update()
    {
        if (following3)
        {
            transform.position = toolTips.transform.position;
        }
    }

}