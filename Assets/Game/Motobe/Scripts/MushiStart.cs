using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MushiStart : MonoBehaviour
{
    private Button button;
    public GameObject board;
    public GameObject back;
    bool big;
    float sin;
    public float speedchange;
    public float sizechange;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(Click);
        big = false;
        back.SetActive(false);
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
            this.gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
    }

    void Click()
    {
        Fade.scene="Main";
        if (this.tag == "Untagged")
        {
            Order.mushikui = false;
            board.SetActive(true);
            back.SetActive(true);
            Board.open = true;
        }
        if (this.tag == "Mushi")
        {
            Order.mushikui = true;
            Order.mushiplus = 0;
            board.SetActive(true);
            back.SetActive(true);
            Board.open = true;
        }
        if (this.tag == "MushiPlus")
        {
            Order.mushikui = true;
            Order.mushiplus = 3;
            board.SetActive(true);
            back.SetActive(true);
            Board.open = true;
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
