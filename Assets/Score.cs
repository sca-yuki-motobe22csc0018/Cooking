using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]public GameObject score;
    public static bool plus;
    public static bool min;
    int count;
    int pscore;

    public GameObject score_object = null; // Text�I�u�W�F�N�g
    public int score_num = 0; // �X�R�A�ϐ�

    // Start is called before the first frame update
    void Start()
    {
        plus=false;
        Text score =GetComponent<Text>();
        count=0;
        
    }

    // Update is called once per frame
    void Update()
    {
        // �I�u�W�F�N�g����Text�R���|�[�l���g���擾
        Text score_text = score_object.GetComponent<Text>();
        score_text.text = "" + score_num;
        if (plus == true)
        {
            count=0;
            score_num += 1000;
            plus = false;
        }
        if (min == true)
        {
            count+=1;
            score_num -= 100*count;
            min = false;
        }
    }
}
