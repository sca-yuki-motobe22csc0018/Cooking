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


    void Start()
    {
        //  �^�C�g����ʕ\�����ݒ��ʔ�\��
        titlePanel.SetActive(true);
        settingPanel.SetActive(false);

        //  �e�{�^���̍ŏ��̃T�C�Y���L��
        defaltStartButtonScale = startButton.transform.localScale;
        defaltSettingButtonScale = settingButton.transform.localScale;
        defaltEndButtonScale = endButton.transform.localScale;
        defaltTitleButtonScale = titleButton.transform.localScale;
    }


    // �Q�[���X�^�[�g
    public void StartGame()
    {
        startButton.transform.DOScale(0.9f, 0.1f).SetEase(Ease.OutElastic).OnComplete(() =>
        {
            startButton.transform.DOScale(1.1f, 0.5f).SetEase(Ease.OutElastic).OnComplete(LoadMainGame);
        });
    }
    private void LoadMainGame()  //  ���C���Q�[���V�[���ǂݍ���
    {
        startButton.transform.DOKill();
        startButton.transform.localScale = defaltStartButtonScale;
        SceneManager.LoadScene("MainGameSelect");//�ύX���܂��� �{��
    }


    // �ݒ��ʊJ��
    public void GameSetting()
    {
        settingButton.transform.DOScale(0.9f, 0.1f).SetEase(Ease.OutElastic).OnComplete(() =>
        {
            settingButton.transform.DOScale(1.1f, 0.5f).SetEase(Ease.OutElastic).OnComplete(LoadGameSetting);
        });
    }
    private void LoadGameSetting()  //  �Z�b�e�B���O��ʓǂݍ���
    {
        settingButton.transform.DOKill();
        settingButton.transform.localScale = defaltSettingButtonScale;

        //  �^�C�g����ʔ�\�����ݒ��ʕ\��
        titlePanel.SetActive(false);
        settingPanel.SetActive(true);
    }


    // �^�C�g����
    public void TitleButton()
    {
        titleButton.transform.DOScale(0.9f, 0.1f).SetEase(Ease.OutElastic).OnComplete(() =>
        {
            titleButton.transform.DOScale(1.1f, 0.5f).SetEase(Ease.OutElastic).OnComplete(LoadTitleScene);
        });
    }
    private void LoadTitleScene()  //  �^�C�g����ʓǂݍ���
    {
        titleButton.transform.DOKill();
        titleButton.transform.localScale = defaltTitleButtonScale;

        //  �^�C�g����ʕ\�����ݒ��ʔ�\��
        titlePanel.SetActive(true);
        settingPanel.SetActive(false);
    }


    //�@�Q�[���I��
    public void EndGame()
    {
        endButton.transform.DOScale(0.9f, 0.1f).SetEase(Ease.OutElastic).OnComplete(() =>
        {
            endButton.transform.DOScale(1.1f, 0.5f).SetEase(Ease.OutElastic).OnComplete(LoadEnd);
        });
    }
    private void LoadEnd()
    {
        endButton.transform.DOKill();
        endButton.transform.localScale = defaltEndButtonScale;

        //  �ȉ��Q�[���I���̃R�[�h
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
		Application.OpenURL("http://www.yahoo.co.jp/");
#else
		Application.Quit();
#endif
    }
}
