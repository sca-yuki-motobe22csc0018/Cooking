using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SelectButton : MonoBehaviour
{

    [SerializeField] private Button VegetableButton;
    [SerializeField] private Button FishMeatButton;
    [SerializeField] private Button OthersButton;
    [SerializeField] private GameObject VegetableShelf;
    [SerializeField] private GameObject FishMeatShelf;
    [SerializeField] private GameObject OthersShelf;
    bool big;
    bool Up;
    public static int sel;
    int a;

    float sin;
    public float speedchange;
    public float sizechange;

    private Button button;

    int TagNum;
    // Start is called before the first frame update
    void Start()
    {
        sel=0;
        Up=false;
        VegetableShelf.SetActive(true);
        string Tag = this.gameObject.tag;
        if (Tag == "VegetableButton")
        {
            TagNum=1;
        }else
        if (Tag == "Fish&MeatButton")
         {
             TagNum = 2;
         }
        else
        if (Tag == "OthersButton")
        {
              TagNum = 3;
        }
        big = false;
        button = GetComponent<Button>();
        button.onClick.AddListener(Select);

        speedchange = 10.0f;
        sizechange = 0.05f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Up == true)
        {
            if(a==0)
            this.transform.position+=new Vector3(0,0.3f,0);
            a=1;
        }
        if (Up == false)
        {
            if(a==1)
            this.transform.position -= new Vector3(0, 0.3f, 0);
            a=0;
        }

        sin = Mathf.Sin(Time.time * speedchange);
        if (big == true)
        {
            this.gameObject.transform.localScale = new Vector3(1.2f + sin * sizechange, 1.2f + sin * sizechange, 1);
        }
        else
        {
            this.gameObject.transform.localScale = new Vector3(1.1f, 1.1f, 1);
        }
        if (sel == 1&& TagNum == 1)
        {
            Up=true;
        }else if(sel == 2 && TagNum == 2)
        {
            Up = true;
        }
        else if (sel == 3 && TagNum == 3)
        {
            Up = true;
        }
        else
        {
            Up=false;
        }
    }

    public void Select()
    {
        ShelfSelect.Change=true;
        if (TagNum == 1)
        {
            sel=1;
            VegetableShelf.SetActive(true);
            FishMeatShelf.SetActive(false);
            OthersShelf.SetActive(false);
        }
        if (TagNum == 2)
        {
            sel=2;
            VegetableShelf.SetActive(false);
            FishMeatShelf.SetActive(true);
            OthersShelf.SetActive(false);
        }
        if (TagNum == 3)
        {
            sel=3;
            VegetableShelf.SetActive(false);
            FishMeatShelf.SetActive(false);
            OthersShelf.SetActive(true);
        }
    }
    public void UP()
    {
        big = true;
    }
    public void Down()
    {
        big = false;
    }
}
