using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class confirmation : MonoBehaviour
{
    public static int dif;
    public GameObject[] Dif;
    public GameObject[] Dif2;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 7; ++i)
        {
            Dif[i].SetActive(false);
        }
        for (int i = 0; i < 7; ++i)
        {
            Dif2[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (dif == 1)
        {
            for (int i = 0; i < 7; ++i)
            {
                Dif[i].SetActive(false);
            }
            for (int i = 0; i < 7; ++i)
            {
                Dif2[i].SetActive(false);
            }
            Dif[0].SetActive(true);
            Dif2[0].SetActive(true);
            dif =0;
        }
        if (dif == 2)
        {
            for (int i = 0; i < 7; ++i)
            {
                Dif[i].SetActive(false);
            }
            for (int i = 0; i < 7; ++i)
            {
                Dif2[i].SetActive(false);
            }
            Dif2[1].SetActive(true);
            Dif[1].SetActive(true);
            dif = 0;
        }
        if (dif == 3)
        {
            for (int i = 0; i < 7; ++i)
            {
                Dif[i].SetActive(false);
            }
            for (int i = 0; i < 7; ++i)
            {
                Dif2[i].SetActive(false);
            }
            Dif2[2].SetActive(true);
            Dif[2].SetActive(true);
            dif = 0;
        }
        if (dif == 4)
        {
            for (int i = 0; i < 7; ++i)
            {
                Dif[i].SetActive(false);
            }
            for (int i = 0; i < 7; ++i)
            {
                Dif2[i].SetActive(false);
            }
            Dif2[3].SetActive(true);
            Dif[3].SetActive(true);
            dif = 0;
        }
        if (dif == 5)
        {
            for (int i = 0; i < 7; ++i)
            {
                Dif[i].SetActive(false);
            }
            for (int i = 0; i < 7; ++i)
            {
                Dif2[i].SetActive(false);
            }
            Dif2[4].SetActive(true);
            Dif[4].SetActive(true);
            dif = 0;
        }
        if (dif == 6)
        {
            for (int i = 0; i < 7; ++i)
            {
                Dif[i].SetActive(false);
            }
            for (int i = 0; i < 7; ++i)
            {
                Dif2[i].SetActive(false);
            }
            Dif2[5].SetActive(true);
            Dif[5].SetActive(true);
            dif = 0;
        }
        if (dif == 7)
        {
            for (int i = 0; i < 7; ++i)
            {
                Dif[i].SetActive(false);
            }
            for (int i = 0; i < 7; ++i)
            {
                Dif2[i].SetActive(false);
            }
            Dif2[6].SetActive(true);
            Dif[6].SetActive(true);
            dif = 0;
        }
    }
}
