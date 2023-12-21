using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DishButton : MonoBehaviour
{
    private Button button;
    public static string Ingredient;
    [SerializeField] public GameObject[] Ingredients;
    bool delete;
    public GameObject del;
    public static int DishCount;
    public int DishNum;
    public GameObject beforeDish;
    private bool Set;
    public static bool set;
    bool delset;

    // Start is called before the first frame update
    void Start()
    {
        Set=false;
        DishCount=0;
        delete=false;
        del.SetActive(false);
        button = GetComponent<Button>();
        button.onClick.AddListener(Click);
        delset=false;
        for(int i = 0; i < 18; ++i)
        {
            Ingredients[i].SetActive(false);
        }
        this.tag= "Untagged";
    }

    // Update is called once per frame
    void Update()
    {
        Ingredient=GameController.Food;
        if (CookingButton.cooking == true)
        {
            for (int i = 0; i < 18; ++i)
            {
                Ingredients[i].SetActive(false);
            }
        }
        if (DishCount == DishNum)
        {
            if (set==true)
            {
                this.tag = Ingredient;
                set = false;    
            }
        }
        if (delset==true&&this.tag!= "Untagged")
        {
            del.SetActive(true);
            delset=false;
        }
        if (this.tag == "Untagged")
        {
            for (int i = 0; i < 18; ++i)
            {
                Ingredients[i].SetActive(false);
            }
            Set=false;
        }

        if (this.tag == "Vegetable01")
        {
            for (int i = 0; i < 18; ++i)
            {
                if (i==0)
                {
                    continue;
                }
                Ingredients[i].SetActive(false);
            }
            Ingredients[0].SetActive(true);
        }

        if (this.tag == "Vegetable02")
        {
            for (int i = 0; i < 18; ++i)
            {
                if (i == 1)
                {
                    continue;
                }
                Ingredients[i].SetActive(false);
            }
            Ingredients[1].SetActive(true);
        }

        if (this.tag == "Vegetable03")
        {
            for (int i = 0; i < 18; ++i)
            {
                if (i == 2)
                {
                    continue;
                }
                Ingredients[i].SetActive(false);
            }
            Ingredients[2].SetActive(true);
        }
        if (this.tag == "Vegetable04")
        {
            for (int i = 0; i < 18; ++i)
            {
                if (i == 3)
                {
                    continue;
                }
                Ingredients[i].SetActive(false);
            }
            Ingredients[3].SetActive(true);
        }
        if (this.tag == "Vegetable05")
        {
            for (int i = 0; i < 18; ++i)
            {
                if (i == 4)
                {
                    continue;
                }
                Ingredients[i].SetActive(false);
            }
            Ingredients[4].SetActive(true);
        }
        if (this.tag == "Vegetable06")
        {
            for (int i = 0; i < 18; ++i)
            {
                if (i == 5)
                {
                    continue;
                }
                Ingredients[i].SetActive(false);
            }
            Ingredients[5].SetActive(true);
        }
        if (this.tag == "MeatFish01")
        {
            for (int i = 0; i < 18; ++i)
            {
                if (i == 6)
                {
                    continue;
                }
                Ingredients[i].SetActive(false);
            }
            Ingredients[6].SetActive(true);
        }
        if (this.tag == "MeatFish02")
        {
            for (int i = 0; i < 18; ++i)
            {
                if (i == 7)
                {
                    continue;
                }
                Ingredients[i].SetActive(false);
            }
            Ingredients[7].SetActive(true);
        }
        if (this.tag == "MeatFish03")
        {
            for (int i = 0; i < 18; ++i)
            {
                if (i == 8)
                {
                    continue;
                }
                Ingredients[i].SetActive(false);
            }
            Ingredients[8].SetActive(true);
        }
        if (this.tag == "MeatFish04")
        {
            for (int i = 0; i < 18; ++i)
            {
                if (i == 9)
                {
                    continue;
                }
                Ingredients[i].SetActive(false);
            }
            Ingredients[9].SetActive(true);
        }
        if (this.tag == "MeatFish05")
        {
            for (int i = 0; i < 18; ++i)
            {
                if (i == 10)
                {
                    continue;
                }
                Ingredients[i].SetActive(false);
            }
            Ingredients[10].SetActive(true);
        }
        if (this.tag == "MeatFish06")
        {
            for (int i = 0; i < 18; ++i)
            {
                if (i == 11)
                {
                    continue;
                }
                Ingredients[i].SetActive(false);
            }
            Ingredients[11].SetActive(true);
        }
        if (this.tag == "Others01")
        {
            for (int i = 0; i < 18; ++i)
            {
                if (i == 12)
                {
                    continue;
                }
                Ingredients[i].SetActive(false);
            }
            Ingredients[12].SetActive(true);
        }
        if (this.tag == "Others02")
        {
            for (int i = 0; i < 18; ++i)
            {
                if (i == 13)
                {
                    continue;
                }
                Ingredients[i].SetActive(false);
            }
            Ingredients[13].SetActive(true);
        }
        if (this.tag == "Others03")
        {
            for (int i = 0; i < 18; ++i)
            {
                if (i == 14)
                {
                    continue;
                }
                Ingredients[i].SetActive(false);
            }
            Ingredients[14].SetActive(true);
        }
        if (this.tag == "Others04")
        {
            for (int i = 0; i < 18; ++i)
            {
                if (i == 15)
                {
                    continue;
                }
                Ingredients[i].SetActive(false);
            }
            Ingredients[15].SetActive(true);
        }
        if (this.tag == "Others05")
        {
            for (int i = 0; i < 18; ++i)
            {
                if (i == 16)
                {
                    continue;
                }
                Ingredients[i].SetActive(false);
            }
            Ingredients[16].SetActive(true);
        }
        if (this.tag == "Others06")
        {
            for (int i = 0; i < 18; ++i)
            {
                if (i == 17)
                {
                    continue;
                }
                Ingredients[i].SetActive(false);
            }
            Ingredients[17].SetActive(true);
        }
    }

    public void SetAt()
    {
        if(this.tag != "Untagged")
        {
            del.SetActive(true);
        }
        
    }

    public void SetAf()
    {
        del.SetActive(false);
        delset=false;
    }

    void Click()
    {
        if (this.tag != "Untagged")
        {
            DishCount -= 1;
            del.SetActive(false);
            delset =true;
        }
        for (int i = 0; i < 18; ++i)
        {
            Ingredients[i].SetActive(false);

            ShelfSelect.Change = true;
        }
        if (DishNum == 1)
        {
            GameController.DishSelect = 1;
        }
        if (DishNum == 2)
        {
            GameController.DishSelect = 2;
        }
        if (DishNum == 3)
        {
            GameController.DishSelect = 3;
        }
        if (DishNum == 4)
        {
            GameController.DishSelect = 4;
        }
        if (DishNum == 5)
        {
            GameController.DishSelect = 5;
        }
        this.tag = "Untagged";
    }
}
