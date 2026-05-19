using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterManager : MonoBehaviour
{
    
    public int waterLeft;
    public int waterNumber;
    public bool level3;
    public Slime slime;
    public Shaker shaker;

    public GameObject shaker1;
    public bool haveWater2;
    public bool completed;

    public GameObject waterPrefab;
    public GameObject endingScreen;
    public GameObject pointChecker;

    public GameObject wineAudio;

    public static bool level1Completed;

    [SerializeField] private Animator shakerOpened;

    public GameObject doneText;



    // Start is called before the first frame update
    void Start()
    {
        haveWater2 = true;
        waterLeft = slime.waterLeft;
        level3 = shaker.level3;
    }

    // Update is called once per frame
    void Update()
    {
        if (level3)
        {

            if (waterNumber == waterLeft)
            {
                doneText.SetActive(true);
                wineAudio.SetActive(false);
                haveWater2 = false;
                StartCoroutine(Timer1());
                completed = true;
                PlayerPrefs.SetInt("Level2Unlocked", completed ? 1 : 0);
                level1Completed = true;
            }

            if (Input.GetKey(KeyCode.Mouse0))
            {
                if (haveWater2)
                {
                    shakerOpened.SetBool("Pouring", true);
                    wineAudio.SetActive(true);
                    GameObject newWater = Object.Instantiate(waterPrefab, transform.position, Quaternion.identity);
                    waterNumber++;
                    
                }

            }

            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                if (haveWater2)
                {
                    shakerOpened.SetBool("Pouring", false);
                }

            }

            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                wineAudio.SetActive(false);
            }
        }
    }

    IEnumerator Timer1()
    {
        
        yield return new WaitForSeconds(5f);
        pointChecker.SetActive(true);
        yield return new WaitForSeconds(1f);
        doneText.SetActive(false);
        endingScreen.SetActive(true);
        shaker1.SetActive(false);

    }

}
