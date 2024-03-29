using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClearCount : MonoBehaviour
{
    public GameObject score_object = null; // Textオブジェクト
    public static int score_num = 0; // スコア変数
    public static int ClearCountSet=2;
    public static bool timer;
    public static bool ccEnd;
    public GameObject Timer;
    public GameObject fade;
    public GameObject back;

    // Start is called before the first frame update
    void Start()
    {
        ccEnd=false;
        back.SetActive(false);
        score_num = 0;
        if (timer == true)
        {
            Timer.SetActive(true);
        }else
        {
            Timer.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Text score_text = score_object.GetComponent<Text>();
        if (ClearCountSet>=10)
        {
            if (score_num<10)
            {
                score_text.text = "Clear: 0" + score_num+"/"+ClearCountSet;
            }
            else
            {
                score_text.text = "Clear: " + score_num+"/"+ClearCountSet;
            }
        }
        else
        {
            score_text.text = "Clear: 0" + score_num + "/0" + ClearCountSet;
        }
        
        
        if (score_num >= ClearCountSet)
        {
            Fade.scene = "Score";
            back.SetActive(true);
            Enemy.move = false;
            if (ccEnd == false)
            {
                ccEnd=true;
                Board.open = true;
            }
        }
    }
}
