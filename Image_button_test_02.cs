using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Image_button_test_02 : MonoBehaviour
{
    public Image image_main;
    public Sprite[] image_mains;    // [0, 1 ,2, 3, 4, 5, 6,.., 30] 31 pictures
    public string selected_name;     // ""
    private int i;


    // new function
    public void select_object()
    {
        selected_name = EventSystem.current.currentSelectedGameObject.name;
        if (selected_name == "Button_left")
        {
            if (i <= 0) { i = image_mains.Length - 1; }
            image_main.overrideSprite = image_mains[--i];   // i = i-1     --i
        }
        else {
            if (i >= image_mains.Length - 1) { i = 0; }
            image_main.overrideSprite = image_mains[++i];  
        
        }
        
    }
}

