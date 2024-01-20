using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] public static string Food;
    [SerializeField] public static string Order;
    public GameObject[] Dish;
    public static int DishSelect;
    public GameObject fade;
    float timer;
    public static int TimeSet;

    // Start is called before the first frame update
    void Start()
    {
        Food=null;
        Order=null;
        fade.gameObject.SetActive(true);
        timer=0;
        TimeSet=0;
    }

    // Update is called once per frame
    void Update()
    {
        timer+=Time.deltaTime;
        if (timer > TimeSet + 1)
        {
            TimeSet+=1;
        }
        //Debug.Log(TimeSet);
        //Debug.Log("GameController.Food="+Food);
        if (DishSelect == 1)
        {
            Dish[0].tag = Dish[1].tag;
            Dish[1].tag = Dish[2].tag;
            Dish[2].tag = Dish[3].tag;
            Dish[3].tag = Dish[4].tag;
            Dish[4].tag = "Untagged";
            DishSelect =0;
        }
        if (DishSelect == 2)
        {
            Dish[1].tag = Dish[2].tag;
            Dish[2].tag = Dish[3].tag;
            Dish[3].tag = Dish[4].tag;
            Dish[4].tag = "Untagged";
            DishSelect = 0;
        }
        if (DishSelect == 3)
        {
            Dish[2].tag = Dish[3].tag;
            Dish[3].tag = Dish[4].tag;
            Dish[4].tag = "Untagged";
            DishSelect = 0;
        }
        if (DishSelect == 4)
        {
            Dish[3].tag = Dish[4].tag;
            Dish[4].tag = "Untagged";
            DishSelect = 0;
        }
        if (DishSelect == 5)
        {
            Dish[4].tag = "Untagged";
            DishSelect = 0;
        }
    }
}
