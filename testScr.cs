using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class testScr : MonoBehaviour
{
    public Image imageScr;
    public float t = 0.0f;   

    // Update is called once per frame
    void Update()
    {
        imageScr.type = Image.Type.Filled;
        imageScr.fillMethod = Image.FillMethod.Radial360;
        imageScr.fillClockwise = false;
        imageScr.fillAmount = t;
        if (t >= 1.0f) {
            t = 0.0f;
        }
        t = t + 0.001f;
    }
}
