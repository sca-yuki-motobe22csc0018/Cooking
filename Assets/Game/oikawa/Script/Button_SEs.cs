using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_SEs : MonoBehaviour
{
    public void Button_ON_SE()
    {
        //  �{�^���ɃJ�[�\�������킹����
        SoundEditer.instance.PlaySE(SoundEditer.SE_Type.ON);
    }

    public void Button_Click_SE()
    {
        //  �{�^���N���b�N��
        SoundEditer.instance.PlaySE(SoundEditer.SE_Type.CLICK);
    }
}
