using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class DialogueCheck1 : MonoBehaviour
{
    public int bloodInGlass;
    public Flowchart mainFlowchart;
    public bool random1;
    public bool random2;
    public bool random3;

    public int randomNumber1;
    public int randomNumber2;
    public int randomNumber3;

    public GameObject dialogueCheck1;

    public GameObject vampireHappy;
    public GameObject vampireNeutral;
    public GameObject vampireAngry;

    public GameObject shakerWall;
    public GameObject fluid;

    public Slime slime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        if (slime.waterLeft >= 0 && slime.waterLeft <= 50)
        {
            vampireNeutral.SetActive(false);
            vampireHappy.SetActive(false);
            vampireAngry.SetActive(true);
            dialogueCheck1.SetActive(false);
            shakerWall.SetActive(false);
            Destroy(fluid);
        }

        if (slime.waterLeft > 50 && slime.waterLeft <= 120)
        {
            vampireNeutral.SetActive(true);
            vampireHappy.SetActive(false);
            vampireAngry.SetActive(false);
            dialogueCheck1.SetActive(false);
            shakerWall.SetActive(false);
            Destroy(fluid);
        }

        if (slime.waterLeft > 120)
        {
            vampireNeutral.SetActive(false);
            vampireHappy.SetActive(true);
            vampireAngry.SetActive(false);
            dialogueCheck1.SetActive(false);
            shakerWall.SetActive(false);
            Destroy(fluid);
        }
    }
}
