using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IngredientButton : MonoBehaviour
{
    private Button button;
    [SerializeField]private string IngredientName;
    [SerializeField]private GameObject Select;
    public bool select=false;


    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(Click);
        select=false;
    }

    // Update is called once per frame
    void Update()
    {
        if (select == true)
        {
            Select.SetActive(true);
            select=false;
        }
    }

    void Click()
    {
        if(DishButton.DishCount<5)
        { 
            DishButton.DishCount += 1;
            GameController.Food = IngredientName;
            ShelfSelect.Change=true;
            //select=true;
        }
    }
}
