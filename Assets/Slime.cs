using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime : MonoBehaviour
{
    public GameObject waterPrefab;
    public bool haveWater1;
    public int waterNumber;
    
    // Start is called before the first frame update
    void Start()
    {
        haveWater1 = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (waterNumber > 400)
        {
            haveWater1 = false;
        }
        if (Input.GetKey(KeyCode.Mouse0))
        {
            if (haveWater1)
            { 
                GameObject newWater = Object.Instantiate(waterPrefab, transform.position, Quaternion.identity);
                waterNumber++;
            }

        }
    }

    /*private void OnCollisionEnter2D(Collider2D other)
    {
        if (other.CompareTag("Wall"))
        {
            transform.localScale = new Vector3(2f, 0.1f, transform.localScale.z);
        }
    } */
}
