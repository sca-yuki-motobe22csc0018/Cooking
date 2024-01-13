using System;
using UnityEngine;

public class ClockManager : MonoBehaviour
{
    //  そっちの仕様に合わせて色々変えて使ってください!-----------------------------------------------------------------


    //  時間指定(いらないかも？) いらないときはここ消してStopTimeが書いてあるところに60.0fいれると１分タイマーになるよ
    [SerializeField] private float stopTime;

    [SerializeField] private GameObject longNeedle;  //  動かしたい針
    private Transform longNeedleAngle;               //  針のtransform取得用変数
    private float moveTime;                          //  稼働時間用変数
    private float mainAngle;                         //  針の角度用変数

    private bool gameStart;                          //  ゲーム開始フラグ


    void Start()
    {
        //  針のComponent取得
        longNeedleAngle = longNeedle.GetComponent<Transform>();

        gameStart = false;  //  とりまストップ 
    }


    void Update()
    {
        //  Spaceで動くよ
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameStart = true;
        }

        //  ゲームスタートフラグONで起動、OFFでリセット
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
        //  タイマー稼働時間
        moveTime += Time.deltaTime;
        //  稼働時間から針の角度を計算
        mainAngle = moveTime * -360.0f / stopTime;
        //  針の移動
        longNeedleAngle.localEulerAngles = new Vector3(0, 0, mainAngle);
        //  制限時間を超えたらタイマーストップ
        if (stopTime <= moveTime)
        {
            gameStart = false;
        }

        //  時間確認用
        Debug.Log(moveTime);
    }

    void TimeReset()
    {
        //  稼働中はリセットしない
        if (gameStart)
        {
            return;
        }

        //  各パラメータ初期化
        longNeedleAngle.localEulerAngles = new Vector3(0, 0, 0);
        moveTime = 0.0f;
    }
}
