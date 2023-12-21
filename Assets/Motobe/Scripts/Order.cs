using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Order : MonoBehaviour
{
    [SerializeField]public GameObject[] order;
    public static bool request;
    int num=0;
    float sin;
    public static int miss;

    // Start is called before the first frame update
    void Start()
    {
        this.tag="Untagged";

        num=0;
        request=false;
        for(int i = 0; i < 13; ++i)
        {
            order[i].SetActive(false);
        }
        miss=0+1;
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
        }
        if (request == false)
        {
            
            num =Random.Range(0,13);
            order[num].SetActive(true);
            this.tag="Untagged";
            if (num == 0)
            {
                this.tag="Food01";
            }
            if (num == 1)
            {
                this.tag = "Food02";
            }
            if (num == 2)
            {
                this.tag = "Food03";
            }
            if (num == 3)
            {
                this.tag = "Food04";
            }
            if (num == 4)
            {
                this.tag = "Food05";
            }
            if (num == 5)
            {
                this.tag = "Food06";
            }
            if (num == 6)
            {
                this.tag = "Food07";
            }
            if (num == 7)
            {
                this.tag = "Food08";
            }
            if (num == 8)
            {
                this.tag = "Food09";
            }
            if (num == 9)
            {
                this.tag = "Food10";
            }
            if (num == 10)
            {
                this.tag = "Food11";
            }
            if (num == 11)
            {
                this.tag = "Food12";
            }
            if (num == 12)
            {
                this.tag = "Food13";
            }
            request =true;
        }
    }
}
