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
        //  スライダーを動かしたときの処理を登録
        BGM_Slider.onValueChanged.AddListener(SetAudioMixerBGM);
        SE_Slider.onValueChanged.AddListener(SetAudioMixerSE);
    }

    public void SetAudioMixerBGM(float value)
    {
        //  5段階補正
        value /= 5;
        //  -80〜0に変換
        var volume = Mathf.Clamp(Mathf.Log10(value) * 20f, -80f, 0f);
        //  audioMixerに代入
        audioMixer.SetFloat("BGM", volume);
        Debug.Log($"BGM:{volume}");
    }

    public void SetAudioMixerSE(float value)
    {
        //  5段階補正
        value /= 6;
        //  -80〜0に変換
        var volume = Mathf.Clamp(Mathf.Log10(value) * 20f, -80f, 0f);
        //  audioMixerに代入
        audioMixer.SetFloat("SE", volume);
        Debug.Log($"SE:{volume}");
    }

    void Update()
    {

    }
}
