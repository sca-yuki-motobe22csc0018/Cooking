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

    // Start is called before the first frame update
    void Start()
    {
        Set=false;
        DishCount=0;
        delete=false;
        del.SetActive(false);
        button = GetComponent<Button>();
        button.onClick.AddListener(Click);
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
            this.tag = Ingredient;
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
            if (Set == false)
            {
                for (int i = 0; i < 18; ++i)
                {
                    Ingredients[i].SetActive(false);
                }
            }
            Ingredients[0].SetActive(true);
            Set =true;
        }
        if (this.tag == "Vegetable02")
        {
            if (Set == false)
            {
                for (int i = 0; i < 18; ++i)
                {
                    Ingredients[i].SetActive(false);
                }
            }
            Ingredients[1].SetActive(true);
            Set = true;
        }
        if (this.tag == "Vegetable03")
        {
            if (Set == false)
            {
                for (int i = 0; i < 18; ++i)
                {
                    Ingredients[i].SetActive(false);
                }
            }
            Ingredients[2].SetActive(true);
            Set = true;
        }
        if (this.tag == "Vegetable04")
        {
            if (Set == false)
            {
                for (int i = 0; i < 18; ++i)
                {
                    Ingredients[i].SetActive(false);
                }
            }
            Ingredients[3].SetActive(true);
            Set = true;
        }
        if (this.tag == "Vegetable05")
        {
            if (Set == false)
            {
                for (int i = 0; i < 18; ++i)
                {
                    Ingredients[i].SetActive(false);
                }
            }
            Ingredients[4].SetActive(true);
            Set = true;
        }
        if (this.tag == "Vegetable06")
        {
            if (Set == false)
            {
                for (int i = 0; i < 18; ++i)
                {
                    Ingredients[i].SetActive(false);
                }
            }
            Ingredients[5].SetActive(true);
            Set = true;
        }
        if (this.tag == "MeatFish01")
        {
            if (Set == false)
            {
                for (int i = 0; i < 18; ++i)
                {
                    Ingredients[i].SetActive(false);
                }
            }
            Ingredients[6].SetActive(true);
            Set = true;
        }
        if (this.tag == "MeatFish02")
        {
            if (Set == false)
            {
                for (int i = 0; i < 18; ++i)
                {
                    Ingredients[i].SetActive(false);
                }
            }
            Ingredients[7].SetActive(true);
            Set = true;
        }
        if (this.tag == "MeatFish03")
        {
            if (Set == false)
            {
                for (int i = 0; i < 18; ++i)
                {
                    Ingredients[i].SetActive(false);
                }
            }
            Ingredients[8].SetActive(true);
            Set = true;
        }
        if (this.tag == "MeatFish04")
        {
            if (Set == false)
            {
                for (int i = 0; i < 18; ++i)
                {
                    Ingredients[i].SetActive(false);
                }
            }
            Ingredients[9].SetActive(true);
            Set = true;
        }
        if (this.tag == "MeatFish05")
        {
            if (Set == false)
            {
                for (int i = 0; i < 18; ++i)
                {
                    Ingredients[i].SetActive(false);
                }
            }
            Ingredients[10].SetActive(true);
            Set = true;
        }
        if (this.tag == "MeatFish06")
        {
            if (Set == false)
            {
                for (int i = 0; i < 18; ++i)
                {
                    Ingredients[i].SetActive(false);
                }
            }
            Ingredients[11].SetActive(true);
            Set = true;
        }
        if (this.tag == "Others01")
        {
            if (Set == false)
            {
                for (int i = 0; i < 18; ++i)
                {
                    Ingredients[i].SetActive(false);
                }
            }
            Ingredients[12].SetActive(true);
            Set = true;
        }
        if (this.tag == "Others02")
        {
            if (Set == false)
            {
                for (int i = 0; i < 18; ++i)
                {
                    Ingredients[i].SetActive(false);
                }
            }
            Ingredients[13].SetActive(true);
            Set = true;
        }
        if (this.tag == "Others03")
        {
            if (Set == false)
            {
                for (int i = 0; i < 18; ++i)
                {
                    Ingredients[i].SetActive(false);
                }
            }
            Ingredients[14].SetActive(true);
            Set = true;
        }
        if (this.tag == "Others04")
        {
            if (Set == false)
            {
                for (int i = 0; i < 18; ++i)
                {
                    Ingredients[i].SetActive(false);
                }
            }
            Ingredients[15].SetActive(true);
            Set = true;
        }
        if (this.tag == "Others05")
        {
            if (Set == false)
            {
                for (int i = 0; i < 18; ++i)
                {
                    Ingredients[i].SetActive(false);
                }
            }
            Ingredients[16].SetActive(true);
            Set = true;
        }
        if (this.tag == "Others06")
        {
            if (Set == false)
            {
                for (int i = 0; i < 18; ++i)
                {
                    Ingredients[i].SetActive(false);
                }
            }
            Ingredients[17].SetActive(true);
            Set = true;
        }

        if (Set == false)
        {
            for (int i = 0; i < 18; ++i)
            {
                Ingredients[i].SetActive(false);
            }
        }
        /*
            if (Ingredient == "Others01")
            {
                Ingredients[12].SetActive(true);
                Ingredient = null;
                GameController.Food = null;
                this.tag = "Others01";
            }
            if (Ingredient == "Others02")
            {
                Ingredients[13].SetActive(true);
                Ingredient = null;
                GameController.Food = null;
                this.tag = "Others02";
            }
            if (Ingredient == "Others03")
            {
                Ingredients[14].SetActive(true);
                Ingredient = null;
                GameController.Food = null;
                this.tag = "Others03";
            }
            if (Ingredient == "Others04")
            {
                Ingredients[15].SetActive(true);
                Ingredient = null;
                GameController.Food = null;
                this.tag = "Others04";
            }
            if (Ingredient == "Others05")
            {
                Ingredients[16].SetActive(true);
                Ingredient = null;
                GameController.Food = null;
                this.tag = "Others05";
            }
            if (Ingredient == "Others06")
            {
                Ingredients[17].SetActive(true);
                Ingredient = null;
                GameController.Food = null;
                this.tag = "Others06";
            }
        }*/
    }

    public void SetAt()
    {
        if(this.tag != "Untagged")
        del.SetActive(true);
    }

    public void SetAf()
    {
        del.SetActive(false);
    }

    void Click()
    {
        Set=false;
        if (this.tag != "Untagged")
        {
            DishCount -= 1;
            del.SetActive(false);
            
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
