using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   //申请一个UI的命名空间
using UnityEngine.EventSystems; //申请一个EventSystems的命名空间

public class text_button_test : MonoBehaviour
{
    public Image image_01;
    public Text text_title;
    public Text text_btn;

    // We set new function
    public void open_close()
    {
        if (text_btn.text == "Open Image")   // ==判定 按钮上的text(文本）是否为 “打开图片“ ； if 如果
        {
            image_01.gameObject.SetActive(true);   // 为真
            text_btn.text = "Close Image";       // 关闭图片
            text_title.text = "Welcome to the Digital World !";//= （附值）
        }
        else {   // 否则
            image_01.gameObject.SetActive(false); //假
            text_btn.text = "Open Image";       // 关闭图片
            text_title.text = "Hello World !";   //  = （附值）
        
        }  
    }
}
