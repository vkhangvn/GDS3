using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int score;
    private bool didCollideThisFrame;

    private Rigidbody2D rb2D;

    private HingeJoint2D hj2D;

    private JointMotor2D motor2D;


    // Start is called before the first frame update
    void Start()
    {
        //Getting my rigidbody & hingejoints
        rb2D = GetComponent<Rigidbody2D>();
        hj2D = GetComponent<HingeJoint2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (rb2D != null)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                Debug.Log("pressing space");
                motor2D.motorSpeed = 500f;
            }
            else
            {
                motor2D.motorSpeed = -500f;
            }

            hj2D.motor = motor2D;
        }

    }
    //collision code
    private void OnCollisionEnter2D(Collision2D other)
    {
        //if you did collide with this, get out
        if (didCollideThisFrame) return;

        //checking that the tag is "edible"
        if (other.gameObject.CompareTag("Edible"))
        {
            //Up score, destroy other
            Debug.Log("This is edible!");
            score++;
            Destroy(other.gameObject);
        }
        //now I DID collide with this
        didCollideThisFrame = true;
    }
}

 