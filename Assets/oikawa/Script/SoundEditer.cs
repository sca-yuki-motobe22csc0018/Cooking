using UnityEngine;

public class SoundEditer : MonoBehaviour
{
    [SerializeField] private AudioSource BGM_AudioSource;
    [SerializeField] private AudioSource SE_AudioSource;

    private void Start()
    {
        // "AudioSource"�R���|�[�l���g���擾
        BGM_AudioSource = gameObject.GetComponent<AudioSource>();
        SE_AudioSource = gameObject.GetComponent<AudioSource>();

    }

    public void BGM_SoundSliderOnValueChange(float newSliderValue)
    {
        // BGM�̉��ʂ��X���C�h�o�[�̒l�ɕύX
        BGM_AudioSource.volume = newSliderValue;
    }

    public void SE_SoundSliderOnValueChange(float newSliderValue)
    {
        //  SE�̉��ʂ��X���C�h�o�[�̒l�ɕύX
        SE_AudioSource.volume = newSliderValue;
    }
}