using System.Collections;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Audio;

/// <summary>
///   音源管理クラス
/// </summary>
public class SoundEditer : MonoBehaviour
{
    public static SoundEditer instance;

    //  BGM管理
    public enum BGM_Type
    {
        //  BGM用の列挙子を登録
        TITLE = 0,
        SELECT = 1,
        MAIN = 2,
        SCORE = 3,
        SILENCE = 999,
    }

    //  SE管理
    public enum SE_Type
    {
        TITLE_CLICK = 0,
        BELL = 1,
        IMPACT = 2,
        CLOCKBELL = 3,
        CLICK = 4,
        ON = 5,
    }

    //  クロスフェード時間
    public const float CROSS_FADE_TIME = 1.0f;

    //  ボリューム関連
    public float BGM_Volume = 0.1f;
    public float SE_Volume = 0.1f;
    public bool Mute = false;

    //=====AudioClip=====
    public AudioClip[] BGM_Clips;
    public AudioClip[] SE_Clips;

    //=====AudioSource=====
    private AudioSource[] BGM_Sources = new AudioSource[4];
    private AudioSource[] SE_Sources = new AudioSource[16];

    private bool isCrossFading;

    private int currentBgmIndex = 999;


    public void SetVolume_SE(float volume)
    {
        SE_Volume = volume;
        foreach (AudioSource source in SE_Sources)
        {
            source.volume = SE_Volume;
        }
    }

    public void SetVolume_BGM(float volume)
    {
        BGM_Volume = volume;
        foreach (AudioSource source in BGM_Sources)
        {
            source.volume = BGM_Volume;
        }
    }

    void Awake()
    {
        //  シングルトンかつ、シーン変遷しても破棄されないようにする
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }


        //  BGM用 AudioSource追加
        for (int i = 0; i < BGM_Sources.Length; i++)
        {
            BGM_Sources[i] = gameObject.AddComponent<AudioSource>();
        }

        //  SE用 AudioSource追加
        for (int i = 0; i < SE_Sources.Length; i++)
        {
            SE_Sources[i] = gameObject.AddComponent<AudioSource>();
        }
    }

    void Update()
    {
        //  ボリューム設定
        if (!isCrossFading)
        {
            for (int i = 0; i < BGM_Sources.Length; i++)
            {
                BGM_Sources[i].volume = BGM_Volume;
            }
            foreach (AudioSource source in SE_Sources)
            {
                source.volume = SE_Volume;
            }
        }
    }

    /// <summary>
    ///  BGM再生
    /// </summary>
    /// <param name="bgmType"></param>
    /// <param name="loopFlag"></param>
    public void PlayBGM(BGM_Type bgmType, bool loopFlag = true)
    {
        //  BGMなしの状態にする場合
        if ((int)bgmType == 999)
        {
            StopBGM();
            return;
        }

        int index = (int)bgmType;
        currentBgmIndex = index;

        if (index < 0 || BGM_Clips.Length <= index)
        {
            return;
        }

        //  同じBGMの場合は何もしない
        if (BGM_Sources[0].clip != null && BGM_Sources[0].clip == BGM_Clips[index])
        {
            return;
        }
        else if (BGM_Sources[1].clip != null && BGM_Sources[1].clip == BGM_Sources[index])
        {
            return;
        }

        //  フェードでBGM開始
        if (BGM_Sources[0].clip == null && BGM_Sources[1].clip == null)
        {
            BGM_Sources[0].loop = loopFlag;
            BGM_Sources[0].clip = BGM_Clips[index];
            BGM_Sources[0].Play();
        }
        else
        {
            //  クロスフェード処理
            StartCoroutine(CrossFadeChangeBGM(index, loopFlag));
        }
    }

    /// <summary>
    ///  BGMのクロスフェード処理
    /// </summary>
    /// <param name="index"></param>
    /// <param name="loopFlag"></param>
    /// <returns></returns>
    private IEnumerator CrossFadeChangeBGM(int index, bool loopFlag)
    {
        isCrossFading = true;
        if (BGM_Sources[0].clip != null)
        {
            //  [0]が再生されている場合、[0]の音量を徐々に下げて、[1]を新しい曲として再生
            BGM_Sources[1].volume = 0;
            BGM_Sources[1].clip = BGM_Clips[index];
            BGM_Sources[1].loop = loopFlag;
            BGM_Sources[1].Play();
            BGM_Sources[1].DOFade(1.0f, CROSS_FADE_TIME).SetEase(Ease.Linear);
            BGM_Sources[1].DOFade(0, CROSS_FADE_TIME).SetEase(Ease.Linear);

            yield return new WaitForSeconds(CROSS_FADE_TIME);
            BGM_Sources[0].Stop();
            BGM_Sources[0].clip = null;
        }
        else
        {
            // [1]が再生されている場合、[1]の音量を徐々に下げて、[0]を新しい曲として再生
            BGM_Sources[0].volume = 0;
            BGM_Sources[0].clip = BGM_Clips[index];
            BGM_Sources[0].loop = loopFlag;
            BGM_Sources[0].Play();
            BGM_Sources[0].DOFade(1.0f, CROSS_FADE_TIME).SetEase(Ease.Linear);
            BGM_Sources[1].DOFade(0, CROSS_FADE_TIME).SetEase(Ease.Linear);

            yield return new WaitForSeconds(CROSS_FADE_TIME);
            BGM_Sources[1].Stop();
            BGM_Sources[1].clip = null;
        }
        isCrossFading = false;
    }

    /// <summary>
    /// BGM完全停止
    /// </summary>
    public void StopBGM()
    {
        BGM_Sources[0].Stop();
        BGM_Sources[1].Stop();
        BGM_Sources[0].clip = null;
        BGM_Sources[1].clip = null;
    }

    /// <summary>
    ///  SE再生
    /// </summary>
    /// <param name="seType"></param>
    public void PlaySE(SE_Type seType)
    {
        int index = (int)seType;
        if (index < 0 || SE_Clips.Length <= index)
        {
            return;
        }

        //  再生中ではないAudioSourceの場合は次のループ処理に移る
        foreach (AudioSource source in SE_Sources)
        {
            //  再生中のAudioSourceの場合には次のループ処理に移る
            if (source.isPlaying)
            {
                continue;
            }

            //  再生中ではないAudioSourceにClipをセットしてSEを鳴らす
            source.clip = SE_Clips[index];
            source.Play();
            break;
        }
    }

    /// <summary>
    ///  SE停止
    /// </summary>
    public void StopSE()
    {
        //  すべてのSE用のAudioSourceを停止する
        foreach (AudioSource source in SE_Sources)
        {
            source.Stop();
            source.clip = null;
        }
    }

    /// <summary>
    ///  BGM一時停止
    /// </summary>
    public void MuteBGM()
    {
        BGM_Sources[0].Stop();
        BGM_Sources[1].Stop();
    }

    /// <summary>
    ///  一時停止された同じBGMを再生
    /// </summary>
    public void ResumeBGM()
    {
        BGM_Sources[0].Play();
        BGM_Sources[1].Play();
    }
}