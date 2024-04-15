using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;

public class ImageDisplay : MonoBehaviour
{
    public RawImage imageDisplay;
    public RawImage imageDisplay2;


    void Start()
    {
        Texture2D selectedTexture = ImageSelector.GetSelectedTexture();

        if (selectedTexture != null)
        {
            imageDisplay.texture = selectedTexture;
            imageDisplay2.texture = selectedTexture;
        }
    }
}
