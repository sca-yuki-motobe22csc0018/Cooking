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
    // Start is called before the first frame update
    void Start()
    {
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
        del.SetActive(false);
        for (int i = 0; i < 18; ++i)
        {
            Ingredients[i].SetActive(false);
            this.tag= "Untagged";
            ShelfSelect.Change=true;
        }

        if (Ingredient == "Vegetable01")
        {
            Ingredients[0].SetActive(true);
            Ingredient=null;
            GameController.Food=null;
            this.tag= "Vegetable01";
        }
        if (Ingredient == "Vegetable02")
        {
            Ingredients[1].SetActive(true);
            Ingredient = null;
            GameController.Food = null;
            this.tag = "Vegetable02";
        }
        if (Ingredient == "Vegetable03")
        {
            Ingredients[2].SetActive(true);
            Ingredient = null;
            GameController.Food = null;
            this.tag = "Vegetable03";
        }
        if (Ingredient == "Vegetable04")
        {
            Ingredients[3].SetActive(true);
            Ingredient = null;
            GameController.Food = null;
            this.tag = "Vegetable04";
        }
        if (Ingredient == "Vegetable05")
        {
            Ingredients[4].SetActive(true);
            Ingredient = null;
            GameController.Food = null;
            this.tag = "Vegetable05";
        }
        if (Ingredient == "Vegetable06")
        {
            Ingredients[5].SetActive(true);
            Ingredient = null;
            GameController.Food = null;
            this.tag = "Vegetable06";
        }
        if (Ingredient == "MeatFish01")
        {
            Ingredients[6].SetActive(true);
            Ingredient = null;
            GameController.Food = null;
            this.tag = "MeatFish01";
        }
        if (Ingredient == "MeatFish02")
        {
            Ingredients[7].SetActive(true);
            Ingredient = null;
            GameController.Food = null;
            this.tag = "MeatFish02";
        }
        if (Ingredient == "MeatFish03")
        {
            Ingredients[8].SetActive(true);
            Ingredient = null;
            GameController.Food = null;
            this.tag = "MeatFish03";
        }
        if (Ingredient == "MeatFish04")
        {
            Ingredients[9].SetActive(true);
            Ingredient = null;
            GameController.Food = null;
            this.tag = "MeatFish04";
        }
        if (Ingredient == "MeatFish05")
        {
            Ingredients[10].SetActive(true);
            Ingredient = null;
            GameController.Food = null;
            this.tag = "MeatFish05";
        }
        if (Ingredient == "MeatFish06")
        {
            Ingredients[11].SetActive(true);
            Ingredient = null;
            GameController.Food = null;
            this.tag = "MeatFish06";
        }
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
        
    }
}
