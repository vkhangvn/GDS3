using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icespawn : MonoBehaviour
{
    public GameObject icePrefab;
    public bool icing;



    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Icepoint"))
        {
            icing = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Icepoint"))
        {
            icing = false;
        }

    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(icing)
            {
                GameObject newIce = Object.Instantiate(icePrefab, transform.position, Quaternion.identity);

            }
        }
    }

}

