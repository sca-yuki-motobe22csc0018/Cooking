using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    public GameObject titlePanel;
    public GameObject settingPanel;

    void Start()
    {
        //  �^�C�g����ʕ\�����ݒ��ʔ�\��
        titlePanel.SetActive(true);
        settingPanel.SetActive(false);
    }

    // �Q�[���X�^�[�g
    public void StartGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    // �ݒ��ʊJ��
    public void GameSetting()
    {
        //  �^�C�g����ʔ�\�����ݒ��ʕ\��
        titlePanel.SetActive(false);
        settingPanel.SetActive(true);
    }

    // �^�C�g����
    public void TitleButton()
    {
        //  �^�C�g����ʕ\�����ݒ��ʔ�\��
        titlePanel.SetActive(true);
        settingPanel.SetActive(false);
    }

    //�@�Q�[���I��
    public void EndGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
		Application.OpenURL("http://www.yahoo.co.jp/");
#else
		Application.Quit();
#endif
    }
}
