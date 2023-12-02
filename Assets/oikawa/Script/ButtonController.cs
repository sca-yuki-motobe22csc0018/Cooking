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
        //  タイトル画面表示＆設定画面非表示
        titlePanel.SetActive(true);
        settingPanel.SetActive(false);
    }

    // ゲームスタート
    public void StartGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    // 設定画面開く
    public void GameSetting()
    {
        //  タイトル画面非表示＆設定画面表示
        titlePanel.SetActive(false);
        settingPanel.SetActive(true);
    }

    // タイトルへ
    public void TitleButton()
    {
        //  タイトル画面表示＆設定画面非表示
        titlePanel.SetActive(true);
        settingPanel.SetActive(false);
    }

    //　ゲーム終了
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
