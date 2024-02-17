using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_SEs : MonoBehaviour
{
    public void Button_ON_SE()
    {
        //  ボタンにカーソルを合わせた時
        SoundEditer.instance.PlaySE(SoundEditer.SE_Type.ON);
    }

    public void Button_Click_SE()
    {
        //  ボタンクリック時
        SoundEditer.instance.PlaySE(SoundEditer.SE_Type.CLICK);
    }
}
