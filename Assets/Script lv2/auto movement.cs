using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class automovement : MonoBehaviour
{

    public float speed = 2.0f;
    public float distance = 5.0f;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Moves back and forth along the X axis
        float newX = Mathf.PingPong(Time.time * speed, distance);
        transform.position = new Vector3(startPosition.x + newX, transform.position.y, transform.position.z);
    }
}

