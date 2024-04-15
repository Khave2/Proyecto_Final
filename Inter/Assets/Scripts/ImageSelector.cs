using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.IO;
using UnityEngine.SceneManagement;
public class ImageSelector : MonoBehaviour
{
    public RawImage imageDisplay;
    private static Texture2D selectedTexture;

    public void OpenGallery()
    {
        NativeGallery.Permission permission = NativeGallery.GetImageFromGallery((path) =>
        {
            if (path != null)
            {
                byte[] imageData = File.ReadAllBytes(path);

                Texture2D texture = new Texture2D(2, 2);
                texture.LoadImage(imageData);

                selectedTexture = texture;

                imageDisplay.texture = texture;


            }
        }, "Select Image", "image/*");

        Debug.Log("Permission result: " + permission);
    }

    public static Texture2D GetSelectedTexture()
    {
        return selectedTexture;
    }
}
