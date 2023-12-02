using UnityEngine;

public class SoundEditer : MonoBehaviour
{
    [SerializeField] private AudioSource BGM_AudioSource;
    [SerializeField] private AudioSource SE_AudioSource;

    private void Start()
    {
        // "AudioSource"コンポーネントを取得
        BGM_AudioSource = gameObject.GetComponent<AudioSource>();
        SE_AudioSource = gameObject.GetComponent<AudioSource>();

    }

    public void BGM_SoundSliderOnValueChange(float newSliderValue)
    {
        // BGMの音量をスライドバーの値に変更
        BGM_AudioSource.volume = newSliderValue;
    }

    public void SE_SoundSliderOnValueChange(float newSliderValue)
    {
        //  SEの音量をスライドバーの値に変更
        SE_AudioSource.volume = newSliderValue;
    }
}