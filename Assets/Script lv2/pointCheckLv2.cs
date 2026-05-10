using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointCheckLv2 : MonoBehaviour
{
    public Spice spice;

    public int waterInGlass;
    public int spiceInGlass;
    public int iceInGlass;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Water"))
        {
            waterInGlass++;
        }

        if (other.CompareTag("Spice"))
        {
            spiceInGlass++;
        }

        if (other.CompareTag("Ice1"))
        {
            iceInGlass++;
        }

        if (other.CompareTag("Ice2"))
        {
            iceInGlass++;
        }

        if (other.CompareTag("Ice3"))
        {
            iceInGlass++;
        }
    }

}
