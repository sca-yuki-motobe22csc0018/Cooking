using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class submissionButton : MonoBehaviour
{
    private Button button;
    public GameObject finbutton;
    float sin;

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
        sin = Mathf.Sin(Time.time * 8);
        this.gameObject.transform.localScale = new Vector3(sin * 0.05f + 1.2f, sin * 0.05f + 1.2f, 1);
    }

    void Click()
    {
        if (finbutton.tag == orderobj.tag)
        {
            Score.plus = true;
            
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
