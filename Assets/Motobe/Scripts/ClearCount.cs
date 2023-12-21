using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClearCount : MonoBehaviour
{
    public GameObject score_object = null; // Textオブジェクト
    public static int score_num = 0; // スコア変数
    public static int ClearCountSet;
    public static bool timer;
    public GameObject Timer;
    // Start is called before the first frame update
    void Start()
    {
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
        if (score_num < 10)
        {
            score_text.text = "Clear:  " + score_num;
        }
        else
        {
            score_text.text = "Clear: " + score_num;
        }
        
        
        if (score_num >= ClearCountSet)
        {
            SceneManager.LoadScene("Score");
        }
    }
}
