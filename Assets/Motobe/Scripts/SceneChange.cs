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
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(Click);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void Click()
    {
        if (this.tag == "Title")
        {
            fade.SetActive(true);
            Fade.fadeout = true;
            Fade.scene = "TitleScene";
            //SceneManager.LoadScene("TitleScene");
        }else if (this.tag == "Restart")
        {
            fade.SetActive(true);
            Fade.fadeout = true;
            Fade.scene = "MainGameSelect";
            //SceneManager.LoadScene("MainGameSelect");
        }else if (this.tag == "Del")
        {
            setting.SetActive(false);
        }
        
    }
}
