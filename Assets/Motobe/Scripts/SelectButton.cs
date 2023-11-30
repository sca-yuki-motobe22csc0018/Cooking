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

    private Button button;

    int TagNum;
    // Start is called before the first frame update
    void Start()
    {
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

        button= GetComponent<Button>();
        button.onClick.AddListener(Select);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Select()
    {
        ShelfSelect.Change=true;
        if (TagNum == 1)
        {
            VegetableShelf.SetActive(true);
            FishMeatShelf.SetActive(false);
            OthersShelf.SetActive(false);
        }
        if (TagNum == 2)
        {
            VegetableShelf.SetActive(false);
            FishMeatShelf.SetActive(true);
            OthersShelf.SetActive(false);
        }
        if (TagNum == 3)
        {
            VegetableShelf.SetActive(false);
            FishMeatShelf.SetActive(false);
            OthersShelf.SetActive(true);
        }
    }
}
