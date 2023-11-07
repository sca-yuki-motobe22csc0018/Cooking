using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] public static string Food;
    [SerializeField] public static string Order;
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
    }
}
