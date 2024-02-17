using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    private Button button;
    public GameObject setting;
    public GameObject fade;
    bool big;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(Click);
        big = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (big == true)
        {
            this.gameObject.transform.localScale = new Vector3(1.2f, 1.2f, 1);
        }
        else
        {
            this.gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
    }

    void Click()
    {
        big = false;
        if (this.tag == "Title")
        {
            fade.SetActive(true);
            Fade.fadeout = true;
            Fade.scene = "TitleScene";
            //SceneManager.LoadScene("TitleScene");
        }
        else if (this.tag == "Restart")
        {
            fade.SetActive(true);
            Fade.fadeout = true;
            Fade.scene = "Main";
            //SceneManager.LoadScene("MainGameSelect");
        }
        else if (this.tag == "Select")
        {
            fade.SetActive(true);
            Fade.fadeout = true;
            Fade.scene = "MainGameSelect";
        }
        else if (this.tag == "Del")
        {
            setting.SetActive(false);
        }

    }

    public void UP()
    {
        big = true;
    }
    public void Down()
    {
        big = false;
    }
}
