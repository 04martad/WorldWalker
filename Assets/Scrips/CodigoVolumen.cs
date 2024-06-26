using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodigoVolumen : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;
    public Image imagenMute;

    private void Start()
    {
        slider.value = PlayerPrefs.GetFloat("VolumenAudio", 0.5f);
        AudioListener.volume = sliderValue;
        RevisarSiEstoyMute();
    }

    public void ChangeSlider(float valor)
    {
        sliderValue = valor;
        PlayerPrefs.SetFloat("volumenAudio", sliderValue);
        AudioListener.volume=sliderValue;
        RevisarSiEstoyMute();
    }

    public void RevisarSiEstoyMute()
    {
        if(sliderValue==0)
        {
            imagenMute.enabled = true;
        }
        else
        {
            imagenMute.enabled=false;
        }
    }
}
