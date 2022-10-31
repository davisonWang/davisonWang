using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class button_image_test : MonoBehaviour
{
    public Image image_00;
    public Text text_title;
    public Text text_button;

    // Update is called once per frame
    public void open_close()
    {
        if (text_button.text == "Open Image")     // if(如果)按钮上(text_button.)的(.)文字的文本（text）判定（是否 ==）“打开图片”（Open Image）执行{}
        {
            image_00.gameObject.SetActive(true);
            text_button.text = "Close Image";     // (=) 赋值为 "Close Image"
            text_title.text = "Welcome to the Digital World!";
        }
        else {                                   // else (如若不然)执行下面花括号里的命令 {}
            image_00.gameObject.SetActive(false);   //假
            text_button.text = "Open Image";
            text_title.text = "Hello World!";
        }
    }
}




