using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaker : MonoBehaviour
{
    public int score;

    public GameObject shaker;

    public GameObject shakerDrop;
    public GameObject glass;

    public bool level3;

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(Timer());
        glass.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Vector3 velocity = rb.velocity;
        float speed = rb.velocity.magnitude;
        

        if (speed > 10f || speed < -10f)
        {
            score++;
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(10f);
        shaker.SetActive(false);
        shakerDrop.SetActive(true);
        glass.SetActive(true);
        level3 = true;
    }
}
