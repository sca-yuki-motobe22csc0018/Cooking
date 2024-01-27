using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndlessButton : MonoBehaviour
{
    private Button button;
    int a;
    public GameObject endlessButton;
    bool endless;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(Click);
        a=0;
        endlessButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (a > 10)
        {
            if (endless==true)
            {
                endlessButton.SetActive(false);
                a=0;
                endless=false;
            }
            if (endless == false)
            {
                endlessButton.SetActive(true);
                a = 0;
                endless = false;
            }
        }
    }
    void Click()
    {
        a+=1;
    }

}
