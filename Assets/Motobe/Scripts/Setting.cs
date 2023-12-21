using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Setting : MonoBehaviour
{
    public GameObject setting;
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        setting.SetActive(false);
        button = GetComponent<Button>();
        button.onClick.AddListener(Click);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Click()
    {
        setting.gameObject.SetActive(true);
    }
}
