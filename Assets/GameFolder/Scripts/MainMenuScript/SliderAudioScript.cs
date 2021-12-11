using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderAudioScript : MonoBehaviour
{
    public Slider volumeSlider;
    // Start is called before the first frame update
    void Start()
    {

        volumeSlider = GetComponent<Slider>();
        volumeSlider.onValueChanged.AddListener(delegate { VolumeChange(); });
        AudioListener.volume = volumeSlider.value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void VolumeChange()
    {
        Debug.Log(volumeSlider.value);
        AudioListener.volume = volumeSlider.value;

    }

}
