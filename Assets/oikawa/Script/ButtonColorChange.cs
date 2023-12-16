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
//    //  �f�t�H���g�J���[
//    [SerializeField] private Color defaltColor;

//    //  �F��ς������{�^������
//    [SerializeField] private Button startButton;
//    [SerializeField] private Button settingButton;
//    [SerializeField] private Button endButton;
//    [SerializeField] private Button titleButton;
//    //  �{�^������������̐F
//    [SerializeField] private Color changeColor;


//    //  �}�E�X�J�[�\�����{�^���ɏ�������̋���
//    private void OnMouseOver()
//    {
//        //  �e�{�^���̃J���[�ύX
//        ButtonColorChange(startButton, changeColor);
//        settingButton.GetComponent<Renderer>().material.color = changeColor;
//        endButton.GetComponent<Renderer>().material.color = changeColor;
//        titleButton.GetComponent<Renderer>().material.color = changeColor;
//    }


//    //  �}�E�X�J�[�\�����{�^�����痣�ꂽ���̋���
//    private void OnMouseExit()
//    {
//        startButton.GetComponent<Renderer>().material.color = defaltColor;
//        settingButton.GetComponent<Renderer>().material.color = defaltColor;
//        endButton.GetComponent<Renderer>().material.color = defaltColor;
//        titleButton.GetComponent<Renderer>().material.color = defaltColor;
//    }
//}
