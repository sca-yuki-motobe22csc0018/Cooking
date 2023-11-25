using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeleteButton : MonoBehaviour
{
    private Button button;
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
        CookingButton.finish=true;
        this.gameObject.SetActive(false);
    }
}