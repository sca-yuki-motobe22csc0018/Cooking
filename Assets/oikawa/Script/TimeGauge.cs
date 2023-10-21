using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeGaugeColorChange : MonoBehaviour
{
    // Ç±Ç±ÇÁï”ÇÕêFí≤êﬂÇÃÇ‚Ç¬
    public Color color_1, color_2, color_3, color_4;
    public float maxTime = 100;
    [Range(0, 100)] public float time = 100;
    private Image image_TimeGauge;
    private float time_ratio;

    // Ç±ÇÍÇÕêßå¿éûä‘
    [SerializeField] private float second;

    void Start()
    {
        image_TimeGauge = gameObject.GetComponent<Image>();
    }

    void Update()
    {
        if (second <= 10)
        {
            time -= 10.0f * Time.deltaTime;
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
