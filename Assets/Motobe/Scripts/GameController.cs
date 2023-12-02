using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] public static string Food;
    [SerializeField] public static string Order;
    public GameObject[] Dish;
    public static int DishSelect;

    // Start is called before the first frame update
    void Start()
    {
        Food=null;
        Order=null;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("GameController.Food="+Food);
        if (DishSelect == 1)
        {
            DishButton.DishCount=1;


            Dish[0].tag = Dish[1].tag;
            Dish[1].tag = Dish[2].tag;
            Dish[2].tag = Dish[3].tag;
            Dish[3].tag = Dish[4].tag;
        }
    }
}
