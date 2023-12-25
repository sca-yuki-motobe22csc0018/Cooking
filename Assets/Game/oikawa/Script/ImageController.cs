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

    // �e�L�g�[�Ƀ��_���\��
    private void RandomMedal()
    {
        int random = 0;

        // SPACE�L�[�Ŏ��s
        if (Input.GetKeyDown(KeyCode.Space))
        {
            random = Random.Range(1, 4);
            Debug.Log("�����_���l��" + random);
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
