using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class newScript : MonoBehaviour
{
    public Image image1;

    public float t = 0.0f;

    // Update is called once per frame
    void Update()
    {
        image1.type = Image.Type.Filled;
        image1.fillMethod = Image.FillMethod.Radial360;
        image1.fillClockwise = true;
        image1.fillAmount = t;
        if (t >= 1.0f) {
            t = 0.0f;   
        }
        t = t + 0.0001f;
    }
}
