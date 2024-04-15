using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio : MonoBehaviour
{
    public AudioSource audios;

    public void ControldeMusica(float sliderMusica)
    {

        audios.volume = sliderMusica;
    }

}
