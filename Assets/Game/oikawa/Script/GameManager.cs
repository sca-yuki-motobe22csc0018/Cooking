using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Start()
    {
        SoundEditer.instance.PlayBGM(SoundEditer.BGM_Type.TITLE);
    }

}
