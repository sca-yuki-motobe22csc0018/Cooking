using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class submissionButton : MonoBehaviour
{
    private Button button;
    public GameObject finbutton;

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

    }

    void Click()
    {
        if (finbutton.tag == orderobj.tag)
        {
            Score.plus = true;
            CookingButton.finish = true;
            Order.request = false;
        }
        else if (finbutton.tag == "Untagged")
        {

        }
        else
        {
            Score.min = true;
            CookingButton.finish = true;
        }
    }
}
