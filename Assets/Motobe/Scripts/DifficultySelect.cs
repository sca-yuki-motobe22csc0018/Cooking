using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DifficultySelect : MonoBehaviour
{
    private Button button;
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
    }

    // Update is called once per frame
    void Update()
    {
        sin = Mathf.Sin(Time.time * speedchange*8);
        if (big == true)
        {
            this.gameObject.transform.localScale = new Vector3(1.2f + sin * sizechange, 1.2f + sin * sizechange, 1);
        }
        else
        {
            this.gameObject.transform.localScale = new Vector3(1,1,1);
        }
    }

    void Click()
    {
        if (this.tag == "easy")
        {
            ClearCount.ClearCountSet=3;
            ClearCount.timer=false;
            SceneManager.LoadScene("Main");
        }
        else if (this.tag == "normal")
        {
            ClearCount.ClearCountSet = 5;
            ClearCount.timer = false;
            SceneManager.LoadScene("Main");
        }
        else if (this.tag == "hard")
        {
            ClearCount.ClearCountSet = 8;
            ClearCount.timer = false;
            SceneManager.LoadScene("Main");
        }
        else if (this.tag == "veryhard")
        {
            ClearCount.ClearCountSet = 10;
            ClearCount.timer = true;
            TimeGaugeColorChange.target_Time=300;
            SceneManager.LoadScene("Main");
        }
        else if (this.tag == "hell")
        {
            ClearCount.ClearCountSet = 20;
            ClearCount.timer = true;
            TimeGaugeColorChange.target_Time = 180;
            SceneManager.LoadScene("Main");
        }
        else if (this.tag == "regacy")
        {
            SceneManager.LoadScene("MainGame");
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
