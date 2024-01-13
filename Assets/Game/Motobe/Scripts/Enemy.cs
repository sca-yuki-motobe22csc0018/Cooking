using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] public GameObject[] Food;
    public static bool change;
    public GameObject cookbutton;
    public GameObject[] evaluation;
    public static bool move;
    public float speed;
    float x;
    // Start is called before the first frame update
    void Start()
    {
        change=false;
        x=0;
        move = true;
        for (int i = 0; i < 13; ++i)
        {
            Food[i].SetActive(false);
        }
        for (int i = 0; i < 6; ++i)
        {
            evaluation[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(x);
        if (move == false)
        {
            x = 0;
        }
        if (Order.miss == 2)
        {
            evaluation[3].SetActive(true);
        }
        if (Order.miss == 3)
        {
            evaluation[4].SetActive(true);
        }
        if (Order.miss == 4)
        {
            evaluation[5].SetActive(true);
        }
        this.transform.position += new Vector3(x,0,0);
        if (Score.plus == true)
        {
            change=true;
            
            if(cookbutton.tag== "Food01")
            {
                Food[0].SetActive(true);
            }
            if (cookbutton.tag == "Food02")
            {
                Food[1].SetActive(true);
            }
            if (cookbutton.tag == "Food03")
            {
                Food[2].SetActive(true);
            }
            if (cookbutton.tag == "Food04")
            {
                Food[3].SetActive(true);
            }
            if (cookbutton.tag == "Food05")
            {
                Food[4].SetActive(true);
            }
            if (cookbutton.tag == "Food06")
            {
                Food[5].SetActive(true);
            }
            if (cookbutton.tag == "Food07")
            {
                Food[6].SetActive(true);
            }
            if (cookbutton.tag == "Food08")
            {
                Food[7].SetActive(true);
            }
            if (cookbutton.tag == "Food09")
            {
                Food[8].SetActive(true);
            }
            if (cookbutton.tag == "Food10")
            {
                Food[9].SetActive(true);
            }
            if (cookbutton.tag == "Food11")
            {
                Food[10].SetActive(true);
            }
            if (cookbutton.tag == "Food12")
            {
                Food[11].SetActive(true);
            }
            if (cookbutton.tag == "Food13")
            {
                Food[12].SetActive(true);
            }
            CookingButton.finish = true;
            if (Order.miss == 1)
            {
                evaluation[0].SetActive(true);
                evaluation[1].SetActive(true);
                evaluation[2].SetActive(true);
            }
            if (Order.miss == 2)
            {
                evaluation[0].SetActive(true);
                evaluation[1].SetActive(true);
            }
            if (Order.miss == 3)
            {
                evaluation[0].SetActive(true);
            }
            x = -speed;
        }
        if (this.transform.position.x<-150)
        {
            x=speed;
            change=false;
            for (int i = 0; i < 13; ++i)
            {
                Food[i].SetActive(false);
            }
            Order.request = false;
            for (int i = 0; i < 6; ++i)
            {
                evaluation[i].SetActive(false);
            }
        }
        if (this.transform.position.x > -80&&change==false)
        {
            x=0;
        }
    }
}
