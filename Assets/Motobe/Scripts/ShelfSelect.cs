using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShelfSelect : MonoBehaviour
{
    //[SerializeField] GameObject[] Select;
    public static bool Change=false;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 18; ++i)
        {
            //Select[i].SetActive(false);
        }
        Change=false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Change == true)
        {
            for (int i = 0; i < 18; ++i)
            {
                //Select[i].SetActive(false);
            }
            Change = false;
        }
    }
}
