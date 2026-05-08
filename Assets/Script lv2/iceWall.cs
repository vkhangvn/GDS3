using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iceWall : MonoBehaviour
{
    public iceCheck iceCheck;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Ice1"))
        {
            iceCheck.ice1Done = true;
        }

        if (collision.gameObject.CompareTag("Ice2"))
        {
            iceCheck.ice2Done = true;
        }

        if (collision.gameObject.CompareTag("Ice3"))
        {
            iceCheck.ice3Done = true;
        }

    }
}
