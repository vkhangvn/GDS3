using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ice : MonoBehaviour
{
    public bool toolTouching;
    public GameObject toolTip;
    public bool following;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Wall2"))
        {
            Destroy(gameObject);
        }

    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("grabPoint"))
        {
            toolTouching = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("grabPoint"))
        {
            toolTouching = false;
        }
    }

    private void Update()
    {
      
        if (toolTouching == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                following = true;
            }

            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                toolTouching = false;
                following = false;
            }
        }

        if (following)
        {
            transform.position = toolTip.transform.position;
        }
    }
}
