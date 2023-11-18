using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishButton : MonoBehaviour
{

    private Button button;
    [SerializeField] public GameObject tagobj;
    [SerializeField] public GameObject orderobj;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(Click);
    }

    // Update is called once per frame
    void Update()
    {
        this.tag = tagobj.tag;
    }

    void Click()
    {
        if (this.tag == orderobj.tag)
        {
            Score.plus=true;
            CookingButton.finish = true;
            Order.request = false;
        }
        else if (this.tag == "Untagged") 
        {
            
        }
        else
        {
            Score.min = true;
            CookingButton.finish = true;
        }
        
        
    }
}
