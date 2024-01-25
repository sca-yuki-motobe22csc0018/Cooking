using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    float cos;
    public Sprite[] skin;
    public Image me;
    public static int skinNum;
    // Start is called before the first frame update
    void Start()
    {
        cos = 0;
        skinNum=0;
    }

    // Update is called once per frame
    void Update()
    {
        me.sprite=skin[skinNum];
        cos = Mathf.Cos(Time.time);
        this.transform.position += new Vector3(0, cos/1500, 0);
    }
}
