using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    // ゲームスタート
    public void StartGame()
    {
        SceneManager.LoadScene("MainGame");
    }

    // 設定画面開く
    public void GameSetting()
    {
        SceneManager.LoadScene("SettingScene");
    }

    // 設定画面閉じる
    public void EndSetting()
    {
        SceneManager.LoadScene("TitleScene");
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
