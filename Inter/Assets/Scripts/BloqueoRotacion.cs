using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueoRotacion : MonoBehaviour
{
    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;


        Screen.autorotateToPortrait = false;
        Screen.autorotateToPortraitUpsideDown = false;
        Screen.autorotateToLandscapeLeft = false;
        Screen.autorotateToLandscapeRight = false;
    }
}
