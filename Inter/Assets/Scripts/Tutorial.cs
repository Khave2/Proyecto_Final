using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public  Sprite[] images;
    public  Image tuto;
    int indiceimagen = 0;

    public Button botonSiguiente;
    public Button botonAnterior;

    void Start()
    {
        tuto.sprite = images[indiceimagen];
        ActualizarBotones();
    }

    public void Sigimage()
    {
        if (indiceimagen < images.Length - 1)
        {
            indiceimagen++;
            tuto.sprite = images[indiceimagen];
            ActualizarBotones();
        }
    }

    public void Antimage()
    {
        if (indiceimagen > 0)
        {
            indiceimagen--;
            tuto.sprite = images[indiceimagen];
            ActualizarBotones();
        }
    }

    void ActualizarBotones()
    {
        botonSiguiente.interactable = indiceimagen < images.Length - 1;

        botonAnterior.interactable = indiceimagen > 0;
    }

}
