using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CookingButton : MonoBehaviour
{
    private Button button;
    public static bool cooking=false;
    public int i=0;
    [SerializeField] public GameObject Dish01;
    [SerializeField] public GameObject Dish02;
    [SerializeField] public GameObject Dish03;
    [SerializeField] public GameObject Dish04;
    [SerializeField] public GameObject Dish05;
    [SerializeField] public GameObject[] Food;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(Click);
        cooking=false;
        i=0;
        for (int i = 0; i < 14; ++i)
        {
            Food[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (cooking == true)
        {
            i+=1;
            if (i > 2)
            {
                cooking=false;
            }
        }
    }

    void Click()
    {
        cooking=true;
        if(Dish01.tag=="Vegetable03"&& Dish02.tag == "Vegetable01"&& Dish03.tag == "Vegetable02" && Dish04.tag == "Others05" && Dish05.tag == "MeatFish02")
        {
            for (int i = 0; i < 14; ++i)
            {
                Food[i].SetActive(false);
            }
            Food[1].SetActive(true);
        }
        else
        if (Dish01.tag == "MeatFish04" && Dish02.tag == "MeatFish05" && Dish03.tag == "Others05" && Dish04.tag == "MeatFish06" && Dish05.tag == "Vegetable03")
        {
            for (int i = 0; i < 14; ++i)
            {
                Food[i].SetActive(false);
            }
            Food[2].SetActive(true);
        }
        else
        if (Dish01.tag == "Vegetable05" && Dish02.tag == "MeatFish03" && Dish03.tag == "Vegetable01" && Dish04.tag == "Vegetable06" && Dish05.tag == "Untagged")
        {
            for (int i = 0; i < 14; ++i)
            {
                Food[i].SetActive(false);
            }
            Food[3].SetActive(true);
        }
        else
        if (Dish01.tag == "Others01" && Dish02.tag == "Others05" && Dish03.tag == "MeatFish03" && Dish04.tag == "Vegetable03" && Dish05.tag == "Untagged")
        {
            for (int i = 0; i < 14; ++i)
            {
                Food[i].SetActive(false);
            }
            Food[4].SetActive(true);
        }
        else
        if (Dish01.tag == "MeatFish04" && Dish02.tag == "MeatFish05" && Dish03.tag == "Others02" && Dish04.tag == "MeatFish03" && Dish05.tag == "Untagged")
        {
            for (int i = 0; i < 14; ++i)
            {
                Food[i].SetActive(false);
            }
            Food[5].SetActive(true);
        }
        else
        if (Dish01.tag == "MeatFish06" && Dish02.tag == "Vegetable04" && Dish03.tag == "Vegetable03" && Dish04.tag == "Untagged" && Dish05.tag == "Untagged")
        {
            for (int i = 0; i < 14; ++i)
            {
                Food[i].SetActive(false);
            }
            Food[6].SetActive(true);
        }
        else
        if (Dish01.tag == "MeatFish06" && Dish02.tag == "MeatFish05" && Dish03.tag == "Others05" && Dish04.tag == "MeatFish04" && Dish05.tag == "Untagged")
        {
            for (int i = 0; i < 14; ++i)
            {
                Food[i].SetActive(false);
            }
            Food[7].SetActive(true);
        }
        else
        if (Dish01.tag == "Vegetable03" && Dish02.tag == "Vegetable02" && Dish03.tag == "MeatFish01" && Dish04.tag == "Untagged" && Dish05.tag == "Untagged")
        {
            for (int i = 0; i < 14; ++i)
            {
                Food[i].SetActive(false);
            }
            Food[8].SetActive(true);
        }
        else
        if (Dish01.tag == "Vegetable02" && Dish02.tag == "Vegetable01" && Dish03.tag == "MeatFish02" && Dish04.tag == "Others03" && Dish05.tag == "Untagged")
        {
            for (int i = 0; i < 14; ++i)
            {
                Food[i].SetActive(false);
            }
            Food[9].SetActive(true);
        }
        else
        if (Dish01.tag == "MeatFish02" && Dish02.tag == "Others01" && Dish03.tag == "Vegetable03" && Dish04.tag == "Others05" && Dish05.tag == "Untagged")
        {
            for (int i = 0; i < 14; ++i)
            {
                Food[i].SetActive(false);
            }
            Food[10].SetActive(true);
        }
        else
        if (Dish01.tag == "Others02" && Dish02.tag == "Vegetable04" && Dish03.tag == "Vegetable05" && Dish04.tag == "Untagged" && Dish05.tag == "Untagged")
        {
            for (int i = 0; i < 14; ++i)
            {
                Food[i].SetActive(false);
            }
            Food[11].SetActive(true);
        }
        else
        if (Dish01.tag == "MeatFish01" && Dish02.tag == "Vegetable03" && Dish03.tag == "Others02" && Dish04.tag == "Untagged" && Dish05.tag == "Untagged")
        {
            for (int i = 0; i < 14; ++i)
            {
                Food[i].SetActive(false);
            }
            Food[12].SetActive(true);
        }
        else
        if (Dish01.tag == "Others02" && Dish02.tag == "Others04" && Dish03.tag == "Vegetable04" && Dish04.tag == "Untagged" && Dish05.tag == "Untagged")
        {
            for (int i = 0; i < 14; ++i)
            {
                Food[i].SetActive(false);
            }
            Food[13].SetActive(true);
        }
        else
        {
            for (int i = 0; i < 14; ++i)
            {
                Food[i].SetActive(false);
            }
            Food[0].SetActive(true);
        }
        Dish01.tag = "Untagged";
        Dish02.tag = "Untagged";
        Dish03.tag = "Untagged";
        Dish04.tag = "Untagged";
        Dish05.tag = "Untagged";
    }
}
