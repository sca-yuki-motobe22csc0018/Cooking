using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Fade : MonoBehaviour
{
    public GameObject fade;

    float fader;
    float a;
    public static bool fadeout;
    public static string scene;
    // Start is called before the first frame update
    void Start()
    {
        fader = 1;
        a = -0.05f;
        fadeout = false;
    }

    // Update is called once per frame
    void Update()
    {
        fader += a;
        Color color = gameObject.GetComponent<Image>().color;
        gameObject.GetComponent<Image>().color = new Color(0, 0, 0, fader);
        if (fadeout == true)
        {
            a = 0.05f;
        }
        else
        if (fader < 0)
        {
            fader = 0;
            this.gameObject.SetActive(false);
        }
        if (fader > 1)
        {

            //  及川：追加(シーン変更時サウンド流す)
            if (scene == "Main")
            {
                SoundEditer.instance.PlayBGM(SoundEditer.BGM_Type.MAIN);
            }
            if (scene == "Title")
            {
                Debug.Log("hoge");
                SoundEditer.instance.PlayBGM(SoundEditer.BGM_Type.TITLE);
            }
            if (scene == "MainGameSelect2")
            {
                SoundEditer.instance.PlayBGM(SoundEditer.BGM_Type.SELECT);
            }
            if (scene == "Score")
            {
                SoundEditer.instance.PlayBGM(SoundEditer.BGM_Type.SCORE);
            }

            fadeout = false;
            SceneManager.LoadScene(scene);
        }
    }
}
