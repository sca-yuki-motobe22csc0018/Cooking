using System;
using UnityEngine;

public class ClockManager : MonoBehaviour
{
    //  �������̎d�l�ɍ��킹�ĐF�X�ς��Ďg���Ă�������!-----------------------------------------------------------------


    //  ���Ԏw��(����Ȃ������H) ����Ȃ��Ƃ��͂���������StopTime�������Ă���Ƃ����60.0f�����ƂP���^�C�}�[�ɂȂ��
    [SerializeField] private float stopTime;

    [SerializeField] private GameObject longNeedle;  //  �����������j
    private Transform longNeedleAngle;               //  �j��transform�擾�p�ϐ�
    private float moveTime;                          //  �ғ����ԗp�ϐ�
    private float mainAngle;                         //  �j�̊p�x�p�ϐ�

    private bool gameStart;                          //  �Q�[���J�n�t���O


    void Start()
    {
        //  �j��Component�擾
        longNeedleAngle = longNeedle.GetComponent<Transform>();

        gameStart = false;  //  �Ƃ�܃X�g�b�v 
    }


    void Update()
    {
        //  Space�œ�����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameStart = true;
        }

        //  �Q�[���X�^�[�g�t���OON�ŋN���AOFF�Ń��Z�b�g
        if (gameStart)
        {
            MoveTime();
        }
        else
        {
            TimeReset();
        }
    }


    void MoveTime()
    {
        //  �^�C�}�[�ғ�����
        moveTime += Time.deltaTime;
        //  �ғ����Ԃ���j�̊p�x���v�Z
        mainAngle = moveTime * -360.0f / stopTime;
        //  �j�̈ړ�
        longNeedleAngle.localEulerAngles = new Vector3(0, 0, mainAngle);
        //  �������Ԃ𒴂�����^�C�}�[�X�g�b�v
        if (stopTime <= moveTime)
        {
            gameStart = false;
        }

        //  ���Ԋm�F�p
        Debug.Log(moveTime);
    }

    void TimeReset()
    {
        //  �ғ����̓��Z�b�g���Ȃ�
        if (gameStart)
        {
            return;
        }

        //  �e�p�����[�^������
        longNeedleAngle.localEulerAngles = new Vector3(0, 0, 0);
        moveTime = 0.0f;
    }
}
