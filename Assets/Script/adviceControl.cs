using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class adviceControl : MonoBehaviour
{
    public List<string> adviceList;
    public TMP_Text displayTextField;
    // Start is called before the first frame update
    void Start()
    {
        setRandomText();
    }

    // Update is called once per frame
    void setRandomText()
    {
        if (adviceList.Count > 0)
        {
            int randomIndex = Random.Range(0, adviceList.Count);
            displayTextField.text = adviceList[randomIndex];
        }
    }
}
