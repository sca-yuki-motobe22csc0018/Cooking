using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class ButtonColorChange : MonoBehaviour
{
    private void ButtonStateColorChange(Button button, Color color, int changeColorState)
    {
        ColorBlock colorBlock = button.colors;
        switch (changeColorState)
        {
            case 0:  //  normalColor
                colorBlock.normalColor = color;
                break;
            case 1:  //  selectedColor
                colorBlock.selectedColor = color;
                break;
        }
        button.colors = colorBlock;
    }

    [SerializeField] private Button stattButton;
    [SerializeField] private Color buttonColor;


    private void OnMouseOver()
    {
        ButtonStateColorChange(stattButton, buttonColor, 2);
    }
}
//public class ButtonColorChange : MonoBehaviour
//{
//    //  デフォルトカラー
//    [SerializeField] private Color defaltColor;

//    //  色を変えたいボタンたち
//    [SerializeField] private Button startButton;
//    [SerializeField] private Button settingButton;
//    [SerializeField] private Button endButton;
//    [SerializeField] private Button titleButton;
//    //  ボタンを押した後の色
//    [SerializeField] private Color changeColor;


//    //  マウスカーソルがボタンに乗った時の挙動
//    private void OnMouseOver()
//    {
//        //  各ボタンのカラー変更
//        ButtonColorChange(startButton, changeColor);
//        settingButton.GetComponent<Renderer>().material.color = changeColor;
//        endButton.GetComponent<Renderer>().material.color = changeColor;
//        titleButton.GetComponent<Renderer>().material.color = changeColor;
//    }


//    //  マウスカーソルがボタンから離れた時の挙動
//    private void OnMouseExit()
//    {
//        startButton.GetComponent<Renderer>().material.color = defaltColor;
//        settingButton.GetComponent<Renderer>().material.color = defaltColor;
//        endButton.GetComponent<Renderer>().material.color = defaltColor;
//        titleButton.GetComponent<Renderer>().material.color = defaltColor;
//    }
//}
