using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class FadeInOutSceneLoad : MonoBehaviour
{
    public Image imageObject;
    public float fadeTime;
    public int nextSceneNum;
    private bool create = false;
    private bool fadeing = false;

    private void Awake() {
        if(!create) {
            DontDestroyOnLoad(this.gameObject);
            create = true;
        }
    }

    void Start()
    {
        fadeIn();
    }

    void fadeInComp() {
        Debug.Log("fade in comp");
        SceneManager.LoadScene(nextSceneNum);
        fadeOut();
    }

    void fadeOutComp() {
        Debug.Log("fade out comp");
        fadeing = false;
    }

    public void fadeIn() {
        if(imageObject != null && !fadeing) { 
            Color color = imageObject.color;
            color.a = 0f;
            imageObject.DOFade(1f, fadeTime).OnComplete(fadeInComp);
            fadeing = true;
        }
    }

    public void fadeOut() {
        if(imageObject != null && fadeing) {
            Color color = imageObject.color;
            color.a = 1f;
            imageObject.DOFade(0f, fadeTime).OnComplete(fadeOutComp);
        }
    }
}
