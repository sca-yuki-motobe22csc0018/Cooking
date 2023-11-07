using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Order : MonoBehaviour
{
    [SerializeField]public GameObject[] order;
    public static bool request;
    int num=0;

    

    // Start is called before the first frame update
    void Start()
    {


        num=0;
        request=false;
        for(int i = 0; i < 13; ++i)
        {
            order[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (request == false)
        {
            for (int i = 0; i < 13; ++i)
            {
                order[i].SetActive(false);
            }
            num =Random.Range(0,13);
            order[num].SetActive(true);
            request=true;
        }
    }
}
