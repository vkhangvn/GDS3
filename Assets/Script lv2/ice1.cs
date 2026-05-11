using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ice1 : MonoBehaviour
{
    //public static int iceCount;
    public bool following1;
    public GameObject toolTips;

    // Update is called once per frame

    void Update()
    {
        if (following1)
        {
            transform.position = toolTips.transform.position;
        }
    }

}
