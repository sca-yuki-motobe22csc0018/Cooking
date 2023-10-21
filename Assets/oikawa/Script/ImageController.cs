using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageController : MonoBehaviour
{
    [SerializeField] private Sprite bronzeMedal;
    [SerializeField] private Sprite silverMedal;
    [SerializeField] private Sprite goldMedal;
    private Image nowMedal;

    void Start()
    {
        nowMedal = GetComponent<Image>();
    }

    void Update()
    {
        RandomMedal();
    }

    // テキトーにメダル表示
    private void RandomMedal()
    {
        int random = 0;

        // SPACEキーで実行
        if (Input.GetKeyDown(KeyCode.Space))
        {
            random = Random.Range(1, 4);
            Debug.Log("ランダム値は" + random);
        }

        if (random == 1)
        {
            nowMedal.sprite = bronzeMedal;
        }
        else if (random == 2)
        {
            nowMedal.sprite = silverMedal;
        }
        else if (random == 3)
        {
            nowMedal.sprite = goldMedal;
        }
    }
}
