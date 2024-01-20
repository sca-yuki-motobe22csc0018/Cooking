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
    float sin;
    public float speedchange;
    public float sizechange;
    public static bool start;

    void Start()
    {
        start=false;
        button = GetComponent<Button>();
        button.onClick.AddListener(Click);
        select=false;
        big=false;
        speedchange=10.0f;
        sizechange=0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        sin = Mathf.Sin(Time.time * speedchange);
        if (select == true)
        {
            //Select.SetActive(true);
            GameController.Food=null;
            select=false;
        }
        if (big == true)
        {
            this.gameObject.transform.localScale=new Vector3(1.2f+sin*sizechange,1.2f+sin*sizechange, 1);
        }
        else if(start==true&&big==false)
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
