using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundVolume : MonoBehaviour
{
    public Slider volumeLimitSlider;
    // Start is called before the first frame update
    void Start()
    {
        AudioListener.volume = Button.volume;
    }
    public void setVolumeLimit()
    {
        volumeLimitSlider.onValueChanged.AddListener(delegate { volumeChangeCheck(); });
    }

    public void volumeChangeCheck()
    {
        Button.volume = volumeLimitSlider.value;
        AudioListener.volume = Button.volume;
    }
}
