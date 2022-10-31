using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class image_button_test_03 : MonoBehaviour
{
    public Image image_main;
    public Sprite[] image_mains;
    private string selected_name;   // ""
    private int t;

    // Update is called once per frame
    public void selected_object()
    {
        selected_name = EventSystem.current.currentSelectedGameObject.name;
        if (selected_name == "Button_left")
        {
            if (t <= 0) { t = image_mains.Length - 1; }
            image_main.overrideSprite = image_mains[t--];
        }
        else {
            if (t >= image_mains.Length - 1) { t = 0; }
            image_main.overrideSprite = image_mains[t++];    // t = t + 1; t++

        }  
    }
}
