using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    private Button button;
    public GameObject setting;
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
            SceneManager.LoadScene("TitleScene");
        }else if (this.tag == "Restart")
        {
            SceneManager.LoadScene("MainGameSelect");
        }else if (this.tag == "Del")
        {
            setting.SetActive(false);
        }
        
    }
}
