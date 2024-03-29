using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class ButtonController : MonoBehaviour
{
    public GameObject titlePanel;
    public GameObject settingPanel;

    private Vector3 defaltStartButtonScale;
    private Vector3 defaltSettingButtonScale;
    private Vector3 defaltEndButtonScale;
    private Vector3 defaltTitleButtonScale;

    [SerializeField] Button startButton;
    [SerializeField] Button settingButton;
    [SerializeField] Button endButton;
    [SerializeField] Button titleButton;

    //追加しました　本部
    public GameObject fade;


    void Start()
    {
        //  タイトル画面表示＆設定画面非表示
        titlePanel.SetActive(true);
        settingPanel.SetActive(false);

        //  各ボタンの最初のサイズを記憶
        defaltStartButtonScale = startButton.transform.localScale;
        defaltSettingButtonScale = settingButton.transform.localScale;
        defaltEndButtonScale = endButton.transform.localScale;
        defaltTitleButtonScale = titleButton.transform.localScale;

        //  タイトルBGM
        SoundEditer.instance.PlayBGM(SoundEditer.BGM_Type.TITLE);
    }


    // ゲームスタート
    public void StartGame()
    {
        //  セレクト画面用BGM
        SoundEditer.instance.PlayBGM(SoundEditer.BGM_Type.SELECT);

        startButton.transform.DOScale(0.1f, 0.1f).SetEase(Ease.OutElastic).OnComplete(() =>
        {
            startButton.transform.DOScale(0.25f, 0.5f).SetEase(Ease.OutElastic).OnComplete(LoadMainGame);
        });
    }
    private void LoadMainGame()  //  メインゲームシーン読み込み
    {
        startButton.transform.DOKill();
        startButton.transform.localScale = defaltStartButtonScale;
        //変更しました 本部
        //SceneManager.LoadScene("Main");
        Fade.scene = "MainGameSelect2";
        fade.SetActive(true);
        Fade.fadeout = true;
    }


    // 設定画面開く
    public void GameSetting()
    {
        settingButton.transform.DOScale(0.15f, 0.1f).SetEase(Ease.OutElastic).OnComplete(() =>
      {
          settingButton.transform.DOScale(0.25f, 0.5f).SetEase(Ease.OutElastic).OnComplete(LoadGameSetting);
      });
    }
    private void LoadGameSetting()  //  セッティング画面読み込み
    {
        settingButton.transform.DOKill();
        settingButton.transform.localScale = defaltSettingButtonScale;

        //  タイトル画面非表示＆設定画面表示
        titlePanel.SetActive(false);
        settingPanel.SetActive(true);
    }


    // タイトルへ
    public void TitleButton()
    {
        SoundEditer.instance.PlayBGM(SoundEditer.BGM_Type.TITLE);  //  タイトルBGM

        titleButton.transform.DOScale(0.15f, 0.1f).SetEase(Ease.OutElastic).OnComplete(() =>
        {
            titleButton.transform.DOScale(0.25f, 0.5f).SetEase(Ease.OutElastic).OnComplete(LoadTitleScene);
        });
    }
    private void LoadTitleScene()  //  タイトル画面読み込み
    {
        titleButton.transform.DOKill();
        titleButton.transform.localScale = defaltTitleButtonScale;

        //  タイトル画面表示＆設定画面非表示
        titlePanel.SetActive(true);
        settingPanel.SetActive(false);
    }


    //　ゲーム終了
    public void EndGame()
    {
        endButton.transform.DOScale(0.15f, 0.1f).SetEase(Ease.OutElastic).OnComplete(() =>
        {
            endButton.transform.DOScale(0.25f, 0.5f).SetEase(Ease.OutElastic).OnComplete(LoadEnd);
        });
    }
    private void LoadEnd()
    {
        endButton.transform.DOKill();
        endButton.transform.localScale = defaltEndButtonScale;

        //  以下ゲーム終了のコード
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
		Application.OpenURL("http://www.yahoo.co.jp/");
#else
		Application.Quit();
#endif
    }
}
