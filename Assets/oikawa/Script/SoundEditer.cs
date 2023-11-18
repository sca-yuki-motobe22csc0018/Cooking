using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SoundEditer : MonoBehaviour
{
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] Slider BGM_Slider;
    [SerializeField] Slider SE_Slider;

    void Start()
    {
        //  �X���C�_�[�𓮂������Ƃ��̏�����o�^
        BGM_Slider.onValueChanged.AddListener(SetAudioMixerBGM);
        SE_Slider.onValueChanged.AddListener(SetAudioMixerSE);
    }

    public void SetAudioMixerBGM(float value)
    {
        //  5�i�K�␳
        value /= 5;
        //  -80�`0�ɕϊ�
        var volume = Mathf.Clamp(Mathf.Log10(value) * 20f, -80f, 0f);
        //  audioMixer�ɑ��
        audioMixer.SetFloat("BGM", volume);
        Debug.Log($"BGM:{volume}");
    }

    public void SetAudioMixerSE(float value)
    {
        //  5�i�K�␳
        value /= 6;
        //  -80�`0�ɕϊ�
        var volume = Mathf.Clamp(Mathf.Log10(value) * 20f, -80f, 0f);
        //  audioMixer�ɑ��
        audioMixer.SetFloat("SE", volume);
        Debug.Log($"SE:{volume}");
    }

    void Update()
    {

    }
}
