using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    void Start()
    {
        //  画面遷移後も音を鳴らし続ける(オブジェクトを壊れないようにする)
        DontDestroyOnLoad(this);

    }
}
