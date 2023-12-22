using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Order : MonoBehaviour
{
    [SerializeField]public GameObject[] order;
    public GameObject[] orderMushikuiplus;
    public static bool request;
    int num=0;
    float sin;
    public static int miss;
    public static bool mushikui;

    // Start is called before the first frame update
    void Start()
    {
        this.tag="Untagged";
        //mushikui = true;
        num=0;
        request=false;
        for(int i = 0; i < 13; ++i)
        {
            order[i].SetActive(false);
        }
        for (int i = 0; i < 37; ++i)
        {
            orderMushikuiplus[i].SetActive(false);
        }
        miss =0+1;
    }

    // Update is called once per frame
    void Update()
    {
        sin = Mathf.Sin(Time.time*miss*miss);
        this.gameObject.transform.localScale = new Vector3(sin*0.1f+1, -sin*0.1f-1, 1);
        if (Score.plus == true)
        {
            for (int i = 0; i < 13; ++i)
            {
                order[i].SetActive(false);
            }
            for (int i = 0; i < 37; ++i)
            {
                orderMushikuiplus[i].SetActive(false);
            }
        }
        if (request == false)
        {
            
            num =Random.Range(0,13);
            //order[num].SetActive(true);
            this.tag="Untagged";
            if (num == 0)
            {
                this.tag="Food01";
                if (mushikui == true)
                {
                    int a = Random.Range(0, 6);
                    if (a <= 2)
                    {
                        order[num].SetActive(true);
                    }
                    if (a == 3)
                    {
                        orderMushikuiplus[0].SetActive(true);
                    }
                    if (a == 4)
                    {
                        orderMushikuiplus[0].SetActive(true);
                    }
                    if (a == 5)
                    {
                        orderMushikuiplus[1].SetActive(true);
                    }
                }
                else
                {
                    order[num].SetActive(true);
                }
            }
            if (num == 1)
            {
                this.tag = "Food02";
                if (mushikui == true)
                {
                    int a = Random.Range(0, 6);
                    if (a <= 2)
                    {
                        order[1].SetActive(true);
                    }
                    if (a == 3)
                    {
                        orderMushikuiplus[2].SetActive(true);
                    }
                    if (a == 4)
                    {
                        orderMushikuiplus[3].SetActive(true);
                    }
                    if (a == 5)
                    {
                        orderMushikuiplus[4].SetActive(true);
                    }
                }
                else
                {
                    order[num].SetActive(true);
                }
            }
            if (num == 2)
            {
                this.tag = "Food03";
                if (mushikui == true)
                {
                    int a = Random.Range(0, 6);
                    if (a <= 2)
                    {
                        order[num].SetActive(true);
                    }
                    if (a == 3)
                    {
                        orderMushikuiplus[5].SetActive(true);
                    }
                    if (a == 4)
                    {
                        orderMushikuiplus[6].SetActive(true);
                    }
                    if (a == 5)
                    {
                        orderMushikuiplus[7].SetActive(true);
                    }
                }
                else
                {
                    order[num].SetActive(true);
                }
            }
            if (num == 3)
            {
                this.tag = "Food04";
                if (mushikui == true)
                {
                    int a = Random.Range(0, 6);
                    if (a <= 2)
                    {
                        order[num].SetActive(true);
                    }
                    if (a == 3)
                    {
                        orderMushikuiplus[8].SetActive(true);
                    }
                    if (a == 4)
                    {
                        orderMushikuiplus[9].SetActive(true);
                    }
                    if (a == 5)
                    {
                        orderMushikuiplus[10].SetActive(true);
                    }
                }
                else
                {
                    order[num].SetActive(true);
                }
            }
            if (num == 4)
            {
                this.tag = "Food05";
                if (mushikui == true)
                {
                    int a = Random.Range(0, 6);
                    if (a <= 2)
                    {
                        order[num].SetActive(true);
                    }
                    if (a == 3)
                    {
                        orderMushikuiplus[11].SetActive(true);
                    }
                    if (a == 4)
                    {
                        orderMushikuiplus[12].SetActive(true);
                    }
                    if (a == 5)
                    {
                        orderMushikuiplus[13].SetActive(true);
                    }
                }
                else
                {
                    order[num].SetActive(true);
                }
            }
            if (num == 5)
            {
                this.tag = "Food06";
                if (mushikui == true)
                {
                    int a = Random.Range(0, 6);
                    if (a <= 2)
                    {
                        order[num].SetActive(true);
                    }
                    if (a == 3)
                    {
                        orderMushikuiplus[14].SetActive(true);
                    }
                    if (a == 4)
                    {
                        orderMushikuiplus[15].SetActive(true);
                    }
                    if (a == 5)
                    {
                        orderMushikuiplus[16].SetActive(true);
                    }
                }
                else
                {
                    order[num].SetActive(true);
                }
            }
            if (num == 6)
            {
                this.tag = "Food07";
                if (mushikui == true)
                {
                    int a = Random.Range(0, 6);
                    if (a <= 2)
                    {
                        order[num].SetActive(true);
                    }
                    if (a == 3)
                    {
                        orderMushikuiplus[17].SetActive(true);
                    }
                    if (a == 4)
                    {
                        orderMushikuiplus[18].SetActive(true);
                    }
                    if (a == 5)
                    {
                        orderMushikuiplus[19].SetActive(true);
                    }
                }
                else
                {
                    order[num].SetActive(true);
                }
            }
            if (num == 7)
            {
                this.tag = "Food08";
                if (mushikui == true)
                {
                    int a = Random.Range(0, 6);
                    if (a <= 2)
                    {
                        order[num].SetActive(true);
                    }
                    if (a == 3)
                    {
                        orderMushikuiplus[20].SetActive(true);
                    }
                    if (a == 4)
                    {
                        orderMushikuiplus[21].SetActive(true);
                    }
                    if (a == 5)
                    {
                        orderMushikuiplus[22].SetActive(true);
                    }
                }
                else
                {
                    order[num].SetActive(true);
                }
            }
            if (num == 8)
            {
                this.tag = "Food09";
                if (mushikui == true)
                {
                    int a = Random.Range(0, 6);
                    if (a <= 2)
                    {
                        order[num].SetActive(true);
                    }
                    if (a == 3)
                    {
                        orderMushikuiplus[23].SetActive(true);
                    }
                    if (a == 4)
                    {
                        orderMushikuiplus[24].SetActive(true);
                    }
                    if (a == 5)
                    {
                        orderMushikuiplus[25].SetActive(true);
                    }
                }
                else
                {
                    order[num].SetActive(true);
                }
            }
            if (num == 9)
            {
                this.tag = "Food10";
                if (mushikui == true)
                {
                    int a = Random.Range(0, 6);
                    if (a <= 2)
                    {
                        order[num].SetActive(true);
                    }
                    if (a == 3)
                    {
                        orderMushikuiplus[26].SetActive(true);
                    }
                    if (a == 4)
                    {
                        orderMushikuiplus[27].SetActive(true);
                    }
                    if (a == 5)
                    {
                        orderMushikuiplus[28].SetActive(true);
                    }
                }
                else
                {
                    order[num].SetActive(true);
                }
            }
            if (num == 10)
            {
                this.tag = "Food11";
                if (mushikui == true)
                {
                    int a = Random.Range(0, 6);
                    if (a <= 2)
                    {
                        order[num].SetActive(true);
                    }
                    if (a == 3)
                    {
                        orderMushikuiplus[29].SetActive(true);
                    }
                    if (a == 4)
                    {
                        orderMushikuiplus[30].SetActive(true);
                    }
                    if (a == 5)
                    {
                        orderMushikuiplus[31].SetActive(true);
                    }
                }
                else
                {
                    order[num].SetActive(true);
                }
            }
            if (num == 11)
            {
                this.tag = "Food12";
                if (mushikui == true)
                {
                    int a = Random.Range(0, 6);
                    if (a <= 2)
                    {
                        order[num].SetActive(true);
                    }
                    if (a == 3)
                    {
                        orderMushikuiplus[32].SetActive(true);
                    }
                    if (a == 4)
                    {
                        orderMushikuiplus[33].SetActive(true);
                    }
                    if (a == 5)
                    {
                        orderMushikuiplus[34].SetActive(true);
                    }
                }
                else
                {
                    order[num].SetActive(true);
                }
            }
            if (num == 12)
            {
                this.tag = "Food13";
                if (mushikui == true)
                {
                    int a = Random.Range(0, 6);
                    if (a <= 2)
                    {
                        order[num].SetActive(true);
                    }
                    if (a == 3)
                    {
                        orderMushikuiplus[35].SetActive(true);
                    }
                    if (a == 4)
                    {
                        orderMushikuiplus[36].SetActive(true);
                    }
                    if (a == 5)
                    {
                        orderMushikuiplus[36].SetActive(true);
                    }
                }
                else
                {
                    order[num].SetActive(true);
                }
            }
            request =true;
        }
    }
}
