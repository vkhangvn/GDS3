using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spice : MonoBehaviour
{
    public bool completed;
    public GameObject spicePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (!completed)
            {
                GameObject newWater = Object.Instantiate(spicePrefab, transform.position, Quaternion.identity);
                completed = true;
            }

        }


    }
}
