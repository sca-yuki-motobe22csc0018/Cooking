using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DifficultySelect : MonoBehaviour
{
    private Button button;
    public GameObject Confirmation;
    bool big;
    float sin;
    public float speedchange;
    public float sizechange;
    public GameObject[] Explanation;
    public int thisdif;
    public GameObject mushiOn;
    public GameObject mushiPlusOn;
    public GameObject mushiOff;
    public static int dif=0;
    // Start is called before the first frame update
    void Start()
    {
        dif=0;
        for (int i = 0; i < 9; ++i)
        {
            Explanation[i].SetActive(false);
        }
        button = GetComponent<Button>();
        button.onClick.AddListener(Click);
        big = false;
        Fade.scene = "Main";
        Order.mushikui = false;
        if (this.tag == "Mushi"||this.tag=="MushiPlus")
        {
            mushiOn.gameObject.SetActive(false);
            mushiPlusOn.gameObject.SetActive(false);
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
                
            }
            else
            {
                mushiOn.SetActive(false);
                mushiPlusOn.SetActive(false);
                mushiOff.SetActive(true);
            }
           
        }
    }

    void Click()
    {
        if (this.tag == "easy")
        {
            
            dif=0;
            ClearCount.ClearCountSet=3;
            ClearCount.timer=false;
            confirmation.dif=1;
            Confirmation.SetActive(true);
            //Fade.fadeout = true;
        }
        else if (this.tag == "normal")
        {
            dif=1;
            ClearCount.ClearCountSet = 5;
            ClearCount.timer = false;
            confirmation.dif =2;
            Confirmation.SetActive(true);
            //Fade.fadeout = true;
        }
        else if (this.tag == "hard")
        {
            dif=2;
            ClearCount.ClearCountSet = 8;
            ClearCount.timer = false;
            confirmation.dif =3;
            Confirmation.SetActive(true);
            //Fade.fadeout = true;
        }
        else if (this.tag == "veryhard")
        {
            dif=3;
            ClearCount.ClearCountSet = 10;
            ClearCount.timer = true;
            TimeGaugeColorChange.target_Time=300;
            confirmation.dif =4;
            Confirmation.SetActive(true);
            //Fade.fadeout = true;
        }
        else if (this.tag == "hell")
        {
            dif=4;
            ClearCount.ClearCountSet = 20;
            ClearCount.timer = true;
            TimeGaugeColorChange.target_Time = 180;
            confirmation.dif =5;
            Confirmation.SetActive(true);
            //Fade.fadeout = true;
        }
        else if (this.tag == "hell2")
        {
            dif=5;
            ClearCount.ClearCountSet = 12;
            ClearCount.timer = true;
            TimeGaugeColorChange.target_Time = 60;
            confirmation.dif =6;
            Confirmation.SetActive(true);
            //Fade.fadeout = true;
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
        else if (this.tag == "Mushi")
        {
            if (Order.mushikui == false)
            {
                Order.mushikui = true;
                Order.mushiplus = 0;
                mushiOn.SetActive(true);
                mushiPlusOn.SetActive(false);
                mushiOff.SetActive(false);
            }
            else
            {
                Order.mushikui = false;

            }
            
        }
        else if (this.tag == "MushiPlus")
        {
            if (Order.mushikui == false)
            {
                Order.mushikui = true;
                Order.mushiplus=3;
                mushiOn.SetActive(false);
                mushiPlusOn.SetActive(true);
                mushiOff.SetActive(false);
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
        for (int i = 0; i < 9; ++i)
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
