using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class button_text : MonoBehaviour
{
    public Image image_01;
    public Text text_01;
    public Text text_button;

    // Update is called once per frame
    public void openClose()
    {
        if (text_button.text == "Open Image")     // 如果if,按钮文字的.文本内容text为"Open Image"，我就让他执行{}花括号里的内容
        {
            image_01.gameObject.SetActive(true);
            text_button.text = "Close Image";
            text_01.text = "Welcome to the Digital World!";
        }
        else {                                    // 否者else，执行下面的操作
            image_01.gameObject.SetActive(false);
            text_button.text = "Open Image";
            text_01.text = "Hello World!";       
        }
        
    }
}
