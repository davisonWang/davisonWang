- 👋 Hi, I’m @davisonWang
- 👀 I’m interested in ...
- 🌱 I’m currently learning ...
- 💞️ I’m looking to collaborate on ...
- 📫 How to reach me ...

<!---
davisonWang/davisonWang is a ✨ special ✨ repository because its `README.md` (this file) appears on your GitHub profile.
You can click the Preview link to take a look at your changes.
--->

//----------------------------------------------------------------------- this is my source code--------------------------------------------------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class button_image_test_03 : MonoBehaviour
{
    public Image image_main;
    public Sprite[] image_mains;         //[1, 2, 3, 4, 5, 6] 数组
    private string selected_name;        // "字符串" string
    private int i;                       //  public float t = 0.0f;      float 小数，浮点数  int 整形

    // Update is called once per frame
    public void selected_image()
    {
        selected_name = EventSystem.current.currentSelectedGameObject.name;
        if (selected_name == "Button_left")
        {
            if (i <= 0) { i = image_mains.Length - 1; }
            image_main.overrideSprite = image_mains[--i];

        }
        else {
            if (i >= image_mains.Length - 1) { i = 0; }
            image_main.overrideSprite = image_mains[++i];
        }
    }
}
