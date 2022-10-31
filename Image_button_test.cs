using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   
using UnityEngine.EventSystems;   

public class Image_button_test : MonoBehaviour
{
    public Image imageScr;
    public Text text_01;
    public Text text_btn;

    // Update is called once per frame
    public void open_close()
    {
        if (text_btn.text == "Open Image")
        {
            imageScr.gameObject.SetActive(true);
            text_btn.text = "Close Image";
            text_01.text = "Welcome to the Digital World !";
        }
        else {
            imageScr.gameObject.SetActive(false);
            text_btn.text = "Open Image";
            text_01.text = "Hello World !";
        
        }
        
    }
}
