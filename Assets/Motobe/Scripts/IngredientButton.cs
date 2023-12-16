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
    bool big;


    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(Click);
        select=false;
        big=false;
    }

    // Update is called once per frame
    void Update()
    {
        if (select == true)
        {
            //Select.SetActive(true);
            GameController.Food=null;
            select=false;
        }
        if (big == true)
        {
            this.gameObject.transform.localScale=new Vector3(1.2f,1.2f,1);
        }
        else
        {
            this.gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
    }

    void Click()
    {
        if(DishButton.DishCount<5)
        { 
            DishButton.DishCount += 1;
            DishButton.set=true;
            GameController.Food = IngredientName;
            ShelfSelect.Change=true;
            //select=true;
        }
    }

    public void UP()
    {
        big=true;
    }
    public void Down()
    {
        big=false;
    }
}
