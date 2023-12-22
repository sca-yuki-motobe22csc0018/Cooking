using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DifficultySelect : MonoBehaviour
{
    private Button button;
    public GameObject fade;
    bool big;
    float sin;
    public float speedchange;
    public float sizechange;
    public GameObject[] Explanation;
    public int thisdif;
    public GameObject mushiOn;
    public GameObject mushiOff;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 7; ++i)
        {
            Explanation[i].SetActive(false);
        }
        button = GetComponent<Button>();
        button.onClick.AddListener(Click);
        big = false;
        Fade.scene = "Main";
        Order.mushikui = false;
        if (this.tag == "Mushi")
        {
            mushiOn.gameObject.SetActive(false);
            mushiOff.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        sin = Mathf.Sin(Time.time * speedchange*8);
        if (big == true)
        {
            this.gameObject.transform.localScale = new Vector3(1.2f + sin * sizechange, 1.2f + sin * sizechange, 1);
        }
        else
        {
            this.gameObject.transform.localScale = new Vector3(1,1,1);
        }
        if (this.tag == "Mushi")
        {
            if (Order.mushikui==true)
            {
                mushiOn.SetActive(true);
                mushiOff.SetActive(false);
            }
            else
            {
                mushiOn.SetActive(false);
                mushiOff.SetActive(true);
            }
           
        }
    }

    void Click()
    {
        if (this.tag == "easy")
        {
            ClearCount.ClearCountSet=3;
            ClearCount.timer=false;
            fade.SetActive(true);
            Fade.fadeout = true;
        }
        else if (this.tag == "normal")
        {
            ClearCount.ClearCountSet = 5;
            ClearCount.timer = false;
            fade.SetActive(true);
            Fade.fadeout = true;
        }
        else if (this.tag == "hard")
        {
            ClearCount.ClearCountSet = 8;
            ClearCount.timer = false;
            fade.SetActive(true);
            Fade.fadeout = true;
        }
        else if (this.tag == "veryhard")
        {
            ClearCount.ClearCountSet = 10;
            ClearCount.timer = true;
            TimeGaugeColorChange.target_Time=300;
            fade.SetActive(true);
            Fade.fadeout = true;
        }
        else if (this.tag == "hell")
        {
            ClearCount.ClearCountSet = 20;
            ClearCount.timer = true;
            TimeGaugeColorChange.target_Time = 180;
            fade.SetActive(true);
            Fade.fadeout = true;
        }
        else if (this.tag == "hell2")
        {
            ClearCount.ClearCountSet = 12;
            ClearCount.timer = true;
            TimeGaugeColorChange.target_Time = 60;
            fade.SetActive(true);
            Fade.fadeout = true;
        }
        else if (this.tag == "Mushi")
        {
            if (Order.mushikui == false)
            {
                Order.mushikui = true;
            }
            else
            {
                Order.mushikui = false;
            }
            
        }
    }

    public void UP()
    {
        big = true;
        for (int i = 0; i < 7; ++i)
        {
            Explanation[i].SetActive(false);
        }
        Explanation[thisdif].SetActive(true);
    }
    public void Down()
    {
        big = false;
    }
}
