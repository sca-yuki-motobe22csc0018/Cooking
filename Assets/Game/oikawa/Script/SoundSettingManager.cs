using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundSettingManager : MonoBehaviour
{
    //  スライダー
    private Slider BGM_VolumeSlider;
    private Slider SE_VolumeSlider;

    //  オーディオソース
    public GameObject BGM_audioSource;
    public GameObject SE_audioSource;
    public GameObject SE_Sub_audioSource;

    //  BGM・SEリスト
    public List<AudioClip> BGMs;
    public List<AudioClip> SEs;

 
    void Start()
    {
        //  シーン内からスライダーを探して取得
        BGM_VolumeSlider = GameObject.Find("BGM_Slider").GetComponent<Slider>();
        SE_VolumeSlider = GameObject.Find("SE_Slider").GetComponent<Slider>();

        //  保存された音量を反映
        BGM_VolumeSlider.value = Update_Volume.BGM_SliderValue;
        SE_VolumeSlider.value = Update_Volume.SE_SliderValue;
    }


    void Update()
    {
        //  スライダーの値を取得
        Update_Volume.BGM_SliderValue = BGM_VolumeSlider.value;
        Update_Volume.SE_SliderValue = SE_VolumeSlider.value;

        //  オーディオの音量を設定
        BGM_VolumeSlider.onValueChanged.AddListener(ChangeVolumeBGM);
        SE_VolumeSlider.onValueChanged.AddListener(ChangeVolumeSE);
    }


    void ChangeVolumeBGM(float newVolume)
    {
        //  スライダーの値によって音量を調整
        BGM_audioSource.GetComponent<AudioSource>().volume = newVolume;
    }
    void ChangeVolumeSE(float newVolume)
    {
        //  スライダーの値によって音量を調整
        SE_audioSource.GetComponent<AudioSource>().volume = newVolume;
        SE_Sub_audioSource.GetComponent<AudioSource>().volume = newVolume;
    }


    //  BGMを鳴らす
    public void Play_BGM(int bgmIndex)
    {
        BGM_audioSource.GetComponent<AudioSource>().clip = BGMs[bgmIndex];
        BGM_audioSource.GetComponent<AudioSource>().Play();
    }
    //  SEを鳴らす
    public void Play_SE(int seIndex)
    {
        SE_audioSource.GetComponent<AudioSource>().clip = SEs[seIndex];
        SE_audioSource.GetComponent<AudioSource>().Play();
    }
}
