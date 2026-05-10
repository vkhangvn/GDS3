using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI lv1Text;
    public TextMeshProUGUI lv2Text;
    // Start is called before the first frame update
    void Start()
    {
        lv1Text.text = string.Format("{0}", HighScore.highScore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
