using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] public GameObject[] Food;
    public static bool change;
    public RectTransform my;
    int x;
    // Start is called before the first frame update
    void Start()
    {
        change=false;
        x=0;
    }

    // Update is called once per frame
    void Update()
    {
        my.position+= new Vector3(x,0,0);
        if (Score.plus == true)
        {
            change=true;
            x=-8;
        }
        if (my.position.x<-200)
        {
            x=8;
            change=false;

            Order.request = false;
        }
        if (my.position.x > 224&&change==false)
        {
            x=0;
        }
    }
}
