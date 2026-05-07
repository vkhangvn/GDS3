using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Icespawn : MonoBehaviour
{
    public GameObject icePrefab;



    // Update is called once per frame
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Icepoint"))
        {
            Debug.Log("work");
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
            
                GameObject newIce = Object.Instantiate(icePrefab, transform.position, Quaternion.identity);
            }
        }
    }
    
}

