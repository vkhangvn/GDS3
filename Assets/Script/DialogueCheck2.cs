using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueCheck2 : MonoBehaviour
{
    public Shaker shaker;

    public bool random1;
    public bool random2;
    public bool random3;

    public GameObject dialogueCheck2;

    public GameObject vampireHappy;
    public GameObject vampireNeutral;
    public GameObject vampireAngry;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (shaker.score >= 0 && shaker.score <= 5)
        {
            vampireNeutral.SetActive(false);
            vampireHappy.SetActive(false);
            vampireAngry.SetActive(true);
            dialogueCheck2.SetActive(false);

        }

        if (shaker.score > 5 && shaker.score <= 15)
        {
            vampireNeutral.SetActive(true);
            vampireHappy.SetActive(false);
            vampireAngry.SetActive(false);
            dialogueCheck2.SetActive(false);
   
        }

        if (shaker.score > 15)
        {
            vampireNeutral.SetActive(false);
            vampireHappy.SetActive(true);
            vampireAngry.SetActive(false);
            dialogueCheck2.SetActive(false);

        }
    }
}

