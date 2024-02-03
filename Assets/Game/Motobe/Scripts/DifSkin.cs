using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifSkin : MonoBehaviour
{
    public Sprite[] skin;
    public Image me;
    public static int skinNum;

    // Start is called before the first frame update
    void Start()
    {
        skinNum=1;
    }

    // Update is called once per frame
    void Update()
    {
        me.sprite = skin[skinNum-1];
    }
}
