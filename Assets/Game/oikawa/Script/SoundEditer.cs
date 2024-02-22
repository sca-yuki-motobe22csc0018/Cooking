using System.Collections;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Audio;

/// <summary>
///   �����Ǘ��N���X
/// </summary>
public class SoundEditer : MonoBehaviour
{
    public static SoundEditer instance;

    //  BGM�Ǘ�
    public enum BGM_Type
    {
        //  BGM�p�̗񋓎q��o�^
        TITLE = 0,
        SELECT = 1,
        MAIN = 2,
        SCORE = 3,
        SILENCE = 999,
    }

    //  SE�Ǘ�
    public enum SE_Type
    {
        TITLE_CLICK = 0,
        BELL = 1,
        IMPACT = 2,
        CLOCKBELL = 3,
        CLICK = 4,
        ON = 5,
    }

    //  �N���X�t�F�[�h����
    public const float CROSS_FADE_TIME = 1.0f;

    //  �{�����[���֘A
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
        //  �V���O���g�����A�V�[���ϑJ���Ă��j������Ȃ��悤�ɂ���
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }


        //  BGM�p AudioSource�ǉ�
        for (int i = 0; i < BGM_Sources.Length; i++)
        {
            BGM_Sources[i] = gameObject.AddComponent<AudioSource>();
        }

        //  SE�p AudioSource�ǉ�
        for (int i = 0; i < SE_Sources.Length; i++)
        {
            SE_Sources[i] = gameObject.AddComponent<AudioSource>();
        }
    }

    void Update()
    {
        //  �{�����[���ݒ�
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
    ///  BGM�Đ�
    /// </summary>
    /// <param name="bgmType"></param>
    /// <param name="loopFlag"></param>
    public void PlayBGM(BGM_Type bgmType, bool loopFlag = true)
    {
        //  BGM�Ȃ��̏�Ԃɂ���ꍇ
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

        //  ����BGM�̏ꍇ�͉������Ȃ�
        if (BGM_Sources[0].clip != null && BGM_Sources[0].clip == BGM_Clips[index])
        {
            return;
        }
        else if (BGM_Sources[1].clip != null && BGM_Sources[1].clip == BGM_Sources[index])
        {
            return;
        }

        //  �t�F�[�h��BGM�J�n
        if (BGM_Sources[0].clip == null && BGM_Sources[1].clip == null)
        {
            BGM_Sources[0].loop = loopFlag;
            BGM_Sources[0].clip = BGM_Clips[index];
            BGM_Sources[0].Play();
        }
        else
        {
            //  �N���X�t�F�[�h����
            StartCoroutine(CrossFadeChangeBGM(index, loopFlag));
        }
    }

    /// <summary>
    ///  BGM�̃N���X�t�F�[�h����
    /// </summary>
    /// <param name="index"></param>
    /// <param name="loopFlag"></param>
    /// <returns></returns>
    private IEnumerator CrossFadeChangeBGM(int index, bool loopFlag)
    {
        isCrossFading = true;
        if (BGM_Sources[0].clip != null)
        {
            //  [0]���Đ�����Ă���ꍇ�A[0]�̉��ʂ����X�ɉ����āA[1]��V�����ȂƂ��čĐ�
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
            // [1]���Đ�����Ă���ꍇ�A[1]�̉��ʂ����X�ɉ����āA[0]��V�����ȂƂ��čĐ�
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
    /// BGM���S��~
    /// </summary>
    public void StopBGM()
    {
        BGM_Sources[0].Stop();
        BGM_Sources[1].Stop();
        BGM_Sources[0].clip = null;
        BGM_Sources[1].clip = null;
    }

    /// <summary>
    ///  SE�Đ�
    /// </summary>
    /// <param name="seType"></param>
    public void PlaySE(SE_Type seType)
    {
        int index = (int)seType;
        if (index < 0 || SE_Clips.Length <= index)
        {
            return;
        }

        //  �Đ����ł͂Ȃ�AudioSource�̏ꍇ�͎��̃��[�v�����Ɉڂ�
        foreach (AudioSource source in SE_Sources)
        {
            //  �Đ�����AudioSource�̏ꍇ�ɂ͎��̃��[�v�����Ɉڂ�
            if (source.isPlaying)
            {
                continue;
            }

            //  �Đ����ł͂Ȃ�AudioSource��Clip���Z�b�g����SE��炷
            source.clip = SE_Clips[index];
            source.Play();
            break;
        }
    }

    /// <summary>
    ///  SE��~
    /// </summary>
    public void StopSE()
    {
        //  ���ׂĂ�SE�p��AudioSource���~����
        foreach (AudioSource source in SE_Sources)
        {
            source.Stop();
            source.clip = null;
        }
    }

    /// <summary>
    ///  BGM�ꎞ��~
    /// </summary>
    public void MuteBGM()
    {
        BGM_Sources[0].Stop();
        BGM_Sources[1].Stop();
    }

    /// <summary>
    ///  �ꎞ��~���ꂽ����BGM���Đ�
    /// </summary>
    public void ResumeBGM()
    {
        BGM_Sources[0].Play();
        BGM_Sources[1].Play();
    }
}