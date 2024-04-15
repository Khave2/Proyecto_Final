using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botones : MonoBehaviour
{
    public GameObject botones;
    private bool sonVisibles = false;

    public void ActivarBotones()
    {
        sonVisibles = !sonVisibles;

        if (sonVisibles)
        {
            botones.SetActive(true);
            LeanTween.moveY(botones.GetComponent<RectTransform>(), -15f, 1.2f).setEase(LeanTweenType.easeOutElastic);
        }
        else
        {
            LeanTween.moveY(botones.GetComponent<RectTransform>(), 854f, 1.2f).setEase(LeanTweenType.easeOutElastic)
                .setOnComplete(() => botones.SetActive(false));
        }
    }
}
