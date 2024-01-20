using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundSettingManager : MonoBehaviour
{
    //  �X���C�_�[
    private Slider BGM_VolumeSlider;
    private Slider SE_VolumeSlider;

    //  �I�[�f�B�I�\�[�X
    public GameObject BGM_audioSource;
    public GameObject SE_audioSource;
    public GameObject SE_Sub_audioSource;

    //  BGM�ESE���X�g
    public List<AudioClip> BGMs;
    public List<AudioClip> SEs;

 
    void Start()
    {
        //  �V�[��������X���C�_�[��T���Ď擾
        BGM_VolumeSlider = GameObject.Find("BGM_Slider").GetComponent<Slider>();
        SE_VolumeSlider = GameObject.Find("SE_Slider").GetComponent<Slider>();

        //  �ۑ����ꂽ���ʂ𔽉f
        BGM_VolumeSlider.value = Update_Volume.BGM_SliderValue;
        SE_VolumeSlider.value = Update_Volume.SE_SliderValue;
    }


    void Update()
    {
        //  �X���C�_�[�̒l���擾
        Update_Volume.BGM_SliderValue = BGM_VolumeSlider.value;
        Update_Volume.SE_SliderValue = SE_VolumeSlider.value;

        //  �I�[�f�B�I�̉��ʂ�ݒ�
        BGM_VolumeSlider.onValueChanged.AddListener(ChangeVolumeBGM);
        SE_VolumeSlider.onValueChanged.AddListener(ChangeVolumeSE);
    }


    void ChangeVolumeBGM(float newVolume)
    {
        //  �X���C�_�[�̒l�ɂ���ĉ��ʂ𒲐�
        BGM_audioSource.GetComponent<AudioSource>().volume = newVolume;
    }
    void ChangeVolumeSE(float newVolume)
    {
        //  �X���C�_�[�̒l�ɂ���ĉ��ʂ𒲐�
        SE_audioSource.GetComponent<AudioSource>().volume = newVolume;
        SE_Sub_audioSource.GetComponent<AudioSource>().volume = newVolume;
    }


    //  BGM��炷
    public void Play_BGM(int bgmIndex)
    {
        BGM_audioSource.GetComponent<AudioSource>().clip = BGMs[bgmIndex];
        BGM_audioSource.GetComponent<AudioSource>().Play();
    }
    //  SE��炷
    public void Play_SE(int seIndex)
    {
        SE_audioSource.GetComponent<AudioSource>().clip = SEs[seIndex];
        SE_audioSource.GetComponent<AudioSource>().Play();
    }
}
