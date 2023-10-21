using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    // �Q�[���X�^�[�g
    public void StartGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    // �ݒ��ʊJ��
    public void GameSetting()
    {
        SceneManager.LoadScene("SettingScene");
    }

    // �^�C�g����
    public void TitleButton()
    {
        SceneManager.LoadScene("TitleScene");
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
