using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    public GameObject setting;
    private Button button;
    bool big;
    // Start is called before the first frame update
    void Start()
    {
        setting.SetActive(false);
        button = GetComponent<Button>();
        button.onClick.AddListener(Click);
        big = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (big == true)
        {
            this.gameObject.transform.localScale = new Vector3(1.2f,1.2f,1);
        }
        else
        {
            this.gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
    }

    void Click()
    {
        setting.gameObject.SetActive(true);
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
