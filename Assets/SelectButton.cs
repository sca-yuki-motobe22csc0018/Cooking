using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SelectButton : MonoBehaviour
{
    private Button button;
    int TagNum;
    // Start is called before the first frame update
    void Start()
    {
        button=GetComponent<Button>();

        string Tag = this.gameObject.tag;
        if (Tag == "VegetableButton")
        {
            TagNum=1;
            Debug.Log(Tag);
        }else
        if (Tag == "Fish&MeatButton")
         {
             TagNum = 2;
            Debug.Log(Tag);
        }
        else
         if (Tag == "OthersButton")
          {
              TagNum = 3;
            Debug.Log(Tag);
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (TagNum)
        {
            case 1:
                break;

            case 2:
                break;

            case 3:
                break;
        };
    }
}
