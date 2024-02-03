using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //  シングルトン開始
    public static SoundManager instance;

    private void Awake()
    {
        CheckInstance();
    }

    void CheckInstance()
    {
        if (instance == null)
        {
            instance = this;

            //  画面遷移後も音を鳴らし続ける(オブジェクトを壊れないようにする)
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    //  シングルトン終わり
}
