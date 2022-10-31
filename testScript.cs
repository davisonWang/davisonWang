using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class testScript : MonoBehaviour
{
    public Image image_01;

    public float t = 0.0f;

    // Update is called once per frame
    void Update()
    {
        image_01.type = Image.Type.Filled;
        image_01.fillMethod = Image.FillMethod.Radial360;
        image_01.fillClockwise = false;
        image_01.fillAmount = t;
        if (t >= 1.1f) {
            t = 0.0f;      
        }
        t = t + 0.001f;
        
    }
}
