using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iceCheck : MonoBehaviour
{
    public bool ice1Done;
    public bool ice2Done;
    public bool ice3Done;

    public GameObject ice;
    public GameObject transitionTimer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (  ice1Done &&  ice2Done && ice3Done )
        {
            ice.SetActive( false );
            transitionTimer.SetActive(true);
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Ice1"))
        {
            ice1Done = true;
        }

        if (other.CompareTag("Ice2"))
        {
            ice2Done = true;
        }

        if (other.CompareTag("Ice3"))
        {
            ice3Done = true;
        }
    }
}
