using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifSel : MonoBehaviour
{
    private Button button;
    bool big;
    public static int dif = 0;
    public GameObject Confirmation;
    float minSize;
    float size;
    float sin;
    float sin2;
    public float speedchange;
    public float sizechange;
    bool back;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(Click);
        dif = 0;
        minSize = 1f;
        size = 0;
    }

    // Update is called once per frame
    void Update()
    {
        sin = Mathf.Sin(Time.time * speedchange * 8);
        sin2 = Mathf.Sin(Time.time * speedchange);
        if (big == true)
        {
            this.gameObject.transform.localScale = new Vector3(1.2f + sin * sizechange, 1.2f + sin * sizechange, 1);
        }
        else
        {
            this.gameObject.transform.localScale = new Vector3(1 + sin2 * sizechange/4, 1 + sin2 * sizechange/4, 1);
        }
        if (back == true)
        {
            if (size < minSize)
            {
                Confirmation.gameObject.transform.localScale = new Vector3(size, size, 0);
                size += 0.1f;
            }
            else
            {
                size = 0;
                back = false;
                //Confirmation.gameObject.SetActive(false);
            }
        }
    }

    void Click()
    {
        if (this.tag == "easy")
        {
            dif = 0;
            ClearCount.ClearCountSet = 3;
            ClearCount.timer = false;
            confirmation.dif = 1;
            DifSkin.skinNum=1;
            Confirmation.SetActive(true);
        }
        else if (this.tag == "normal")
        {
            dif = 1;
            ClearCount.ClearCountSet = 5;
            ClearCount.timer = false;
            confirmation.dif = 2;
            DifSkin.skinNum = 2;
            Confirmation.SetActive(true);
        }
        else if (this.tag == "hard")
        {
            dif = 2;
            ClearCount.ClearCountSet = 8;
            ClearCount.timer = false;
            confirmation.dif = 3;
            DifSkin.skinNum = 3;
            Confirmation.SetActive(true);
        }
        else if (this.tag == "veryhard")
        {
            dif = 3;
            ClearCount.ClearCountSet = 10;
            ClearCount.timer = true;
            TimeGaugeColorChange.target_Time = 300;
            confirmation.dif = 4;
            DifSkin.skinNum = 4;
            Confirmation.SetActive(true);
        }
        else if (this.tag == "hell")
        {
            dif = 4;
            ClearCount.ClearCountSet = 20;
            ClearCount.timer = true;
            TimeGaugeColorChange.target_Time = 180;
            confirmation.dif = 5;
            DifSkin.skinNum = 5;
            Confirmation.SetActive(true);
        }
        else if (this.tag == "hell2")
        {
            dif = 5;
            ClearCount.ClearCountSet = 12;
            ClearCount.timer = true;
            TimeGaugeColorChange.target_Time = 60;
            confirmation.dif = 6;
            DifSkin.skinNum = 6;
            Confirmation.SetActive(true);
        }
        else if (this.tag == "endless")
        {
            dif = 6;
            ClearCount.ClearCountSet = 99;
            ClearCount.timer = true;
            TimeGaugeColorChange.target_Time = 60;
            confirmation.dif = 7;
            Confirmation.SetActive(true);
        }
        back=true;
    }

    public void UP()
    {
        big = true;
    }
    public void Down()
    {
        big = false;
    }
}
