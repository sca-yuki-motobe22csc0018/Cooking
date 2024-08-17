using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSet : MonoBehaviour
{
    public GameObject score_object = null;
    public GameObject clear_object = null;
    public GameObject clear;
    public GameObject faild;
    public static int Star;
    public GameObject star;
    // Start is called before the first frame update
    void Start()
    {
        clear.gameObject.SetActive(false);
        faild.gameObject.SetActive(false);
        if (ClearCount.score_num == ClearCount.ClearCountSet&&Score.score_num>0)
        {
            clear.gameObject.SetActive(true);
            if (Score.score_num / 1000 >= ClearCount.score_num)
            {
                Star=3;
                PlayerMove.skinNum = 1;
            }else
                if (Score.score_num / 1000 >= ClearCount.score_num/2)
            {
                Star = 2;
                PlayerMove.skinNum = 0;
            }
            else if (Score.score_num==0)
            {
                Star = 1;
                PlayerMove.skinNum = 2;
            }
            else if (Score.score_num < 0)
            {
                Star = 0;
                PlayerMove.skinNum = 2;
            }
        }
        else
        {
            faild.gameObject.SetActive(true);
            PlayerMove.skinNum=4;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        Text score_text = score_object.GetComponent<Text>();
        score_text.text = "" + Score.score_num;
        

        Text clear_text = clear_object.GetComponent<Text>();
        if (ClearCount.ClearCountSet >= 10)
        {
            if (ClearCount.score_num < 10)
            {
                clear_text.text = "Clear:0" + ClearCount.score_num + "/" + ClearCount.ClearCountSet;
            }
            else
            {
                clear_text.text = "Clear:" + ClearCount.score_num + "/" + ClearCount.ClearCountSet;
            }
        }
        else
        {
            clear_text.text = "Clear:0" + ClearCount.score_num + "/0" + ClearCount.ClearCountSet;
        }
    }
}
