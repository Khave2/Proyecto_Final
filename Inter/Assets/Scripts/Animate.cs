using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{
    public GameObject logo;
 
 


    void Start()
    {
        LeanTween.moveY(logo.GetComponent<RectTransform>(), 90, 1.5f).setEase(LeanTweenType.easeOutBounce).setDelay(0.5f);

        
    }


}
