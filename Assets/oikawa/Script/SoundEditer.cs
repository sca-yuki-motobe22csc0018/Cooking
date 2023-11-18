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
        //  ƒXƒ‰ƒCƒ_[‚ğ“®‚©‚µ‚½‚Æ‚«‚Ìˆ—‚ğ“o˜^
        BGM_Slider.onValueChanged.AddListener(SetAudioMixerBGM);
        SE_Slider.onValueChanged.AddListener(SetAudioMixerSE);
    }

    public void SetAudioMixerBGM(float value)
    {
        //  5’iŠK•â³
        value /= 5;
        //  -80`0‚É•ÏŠ·
        var volume = Mathf.Clamp(Mathf.Log10(value) * 20f, -80f, 0f);
        //  audioMixer‚É‘ã“ü
        audioMixer.SetFloat("BGM", volume);
        Debug.Log($"BGM:{volume}");
    }

    public void SetAudioMixerSE(float value)
    {
        //  5’iŠK•â³
        value /= 6;
        //  -80`0‚É•ÏŠ·
        var volume = Mathf.Clamp(Mathf.Log10(value) * 20f, -80f, 0f);
        //  audioMixer‚É‘ã“ü
        audioMixer.SetFloat("SE", volume);
        Debug.Log($"SE:{volume}");
    }

    void Update()
    {

    }
}
