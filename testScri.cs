using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class testScri : MonoBehaviour
{
    public Image image_00;

    public float t = 0.0f;

    // Update is called once per frame
    void Update()
    {
        image_00.type = Image.Type.Filled;
        image_00.fillMethod = Image.FillMethod.Radial360;
        image_00.fillClockwise = false;
        image_00.fillAmount = t;
        if (t >= 1.0f) {
            t = 0.0f;
        }
        t = t + 0.001f;
    }
}
