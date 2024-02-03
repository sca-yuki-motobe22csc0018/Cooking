using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextBackButton : MonoBehaviour
{
    private Button button;
    bool big;
    public GameObject Next;
    public GameObject Back;
    float sin;
    public float speedchange;
    public float sizechange;
    public float speed;
    bool next;
    bool back;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(Click);
        next=false;
        back=false;
    }

    // Update is called once per frame
    void Update()
    {
        sin = Mathf.Sin(Time.time * speedchange * 8);
        if (big == true)
        {
            this.gameObject.transform.localScale = new Vector3(1.2f + sin * sizechange, 1.2f + sin * sizechange, 1);
        }
        else
        {
            this.gameObject.transform.localScale = new Vector3(1f + sin * sizechange*2, 1f + sin * sizechange*2, 1);
        }
        if (next == true)
        {
            if (Next.gameObject.transform.position.x >= 1)
            {
                Next.gameObject.transform.position -= new Vector3(speed, 0, 0);
                Back.gameObject.transform.position -= new Vector3(speed, 0, 0);
            }
            else
            {
                //Next.gameObject.transform.position = new Vector3(0, 0, 0);
                //Back.gameObject.transform.position = new Vector3(-1920, 0, 0);
                next =false;
            }
        }
        if (back == true)
        {
            if (Back.gameObject.transform.position.x <= -1)
            {
                Next.gameObject.transform.position += new Vector3(speed, 0, 0);
                Back.gameObject.transform.position += new Vector3(speed, 0, 0);
            }
            else
            {
                //Next.gameObject.transform.position = new Vector3(1920, 0, 0);
                //Back.gameObject.transform.position = new Vector3(0, 0, 0);
                back = false;
            }
        }
    }

    void Click()
    {
        if (this.tag == "next")
        {
            next=true;
        }
        if (this.tag == "back")
        {
            back=true;
        }
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
