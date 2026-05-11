using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iceGrabPoint : MonoBehaviour
{
    public bool ice1Touching;
    public bool ice2Touching;
    public bool ice3Touching;
    public ice1 ice1;
    public ice2 ice2;
    public ice3 ice3;
    public bool grabbing;

    void Start()
    {
        
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ice1"))
        {
            ice1Touching = true;
        }

        if (other.CompareTag("Ice2"))
        {
            ice2Touching = true;
        }

        if (other.CompareTag("Ice3"))
        {
            ice3Touching = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Ice1"))
        {
            ice1Touching = false;
        }

        if (other.CompareTag("Ice2"))
        {
            ice2Touching = false;
        }

        if (other.CompareTag("Ice3"))
        {
            ice3Touching = false;
        }
    }

    private void Update()
    {

        if (ice1Touching == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (!grabbing)
                {
                    ice1.following1 = true;
                    grabbing = true;
                }
            }

            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                ice1Touching = false;
                ice1.following1 = false;
                grabbing = false;
            }
        }

        if (ice2Touching == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (!grabbing)
                {
                    ice2.following2 = true;
                    grabbing = true;
                }
            }

            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                ice2Touching = false;
                ice2.following2 = false;
                grabbing = false;
            }
        }


        if (ice3Touching == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (!grabbing)
                {
                    ice3.following3 = true;
                    grabbing = true;
                }
            }

            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                ice3Touching = false;
                ice3.following3 = false;
                grabbing = false;
            }
        }
    }
}
