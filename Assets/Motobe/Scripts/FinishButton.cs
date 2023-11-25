using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishButton : MonoBehaviour
{
    [SerializeField] public GameObject tagobj;
    public GameObject delButton;

    // Start is called before the first frame update
    void Start()
    {
        delButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        this.tag = tagobj.tag;
    }

    
    public void delOn()
    {
        if (this.tag!="Untagged")
        {
            delButton.SetActive(true);
        }
    }

    public void delOff()
    {
        delButton.SetActive(false);
    }
}
