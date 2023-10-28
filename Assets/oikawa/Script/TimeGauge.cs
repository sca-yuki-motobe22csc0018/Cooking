using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeGaugeColorChange : MonoBehaviour
{
    // ここら辺は色調節のやつ
    public Color color_1, color_2, color_3, color_4;
    public float maxTime = 100;
    [Range(0, 100)] public float time = 100;
    private Image image_TimeGauge;
    private float time_ratio;


    [SerializeField] private float target_Time; //  目標タイム(何秒でゲージを変化させたいか)
    private float second;                       // これは残り時間
    private float target_Frame;                 //  ゲージの減る量

    void Start()
    {
        image_TimeGauge = gameObject.GetComponent<Image>();

        //  ここで一秒にどのくらいゲージを減らすか計算
        target_Frame = 100 / target_Time;
        //  自動で残り時間も調整
        second = target_Time;
    }

    void Update()
    {
        //  残り時間が目標時間より小さい時に実行
        if (second <= target_Time)
        {
            time -= target_Frame * Time.deltaTime;
            time_ratio = time / maxTime;
            second -= Time.deltaTime;

            if (time_ratio > 0.75f)
            {
                image_TimeGauge.color = Color.Lerp(color_2, color_1, (time_ratio - 0.75f) * 4f);
            }
            else if (time_ratio > 0.25f)
            {
                image_TimeGauge.color = Color.Lerp(color_3, color_2, (time_ratio - 0.25f) * 4f);
            }
            else
            {
                image_TimeGauge.color = Color.Lerp(color_4, color_3, time_ratio * 4f);
            }

            image_TimeGauge.fillAmount = time_ratio;
        }
        if (second <= 0)
        {
            SceneManager.LoadScene("ScoreScene");
        }
    }
}
