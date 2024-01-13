using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    //  �V���O���g���J�n
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

            //  ��ʑJ�ڌ������炵������(�I�u�W�F�N�g�����Ȃ��悤�ɂ���)
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    //  �V���O���g���I���
}
