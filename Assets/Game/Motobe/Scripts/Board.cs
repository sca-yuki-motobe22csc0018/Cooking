using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Board : MonoBehaviour
{
    public Image board;
    RectTransform rec;
    public GameObject fade;
    public static bool open;
    
    // Start is called before the first frame update
    void Start()
    {
        board=GetComponent<Image>();
        rec=GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (open == true)
        {
            open = false;
            move();
        }
    }

    public void move()
    {
        var sequence = DOTween.Sequence();
        sequence
            .Append(rec.DOAnchorPosY(600.0f, 0))
            .Join(this.transform.DORotate(new Vector3(0, 0, -40), 0))
            .Append(rec.DOAnchorPosY(-200.0f, 0.5f))
            .Join(this.transform.DORotate(new Vector3(0, 0, 20), 0.5f))
            .SetEase(Ease.OutBounce)
            .Append(this.transform.DORotate(new Vector3(0, 0, -10), 0.75f))
            .SetEase(Ease.InOutCubic)
            .Append(this.transform.DORotate(new Vector3(0, 0, 0), 0.75f))
            .SetEase(Ease.InOutCubic)
            .AppendInterval(0.25f)
            .Append(rec.DOAnchorPosY(-150.0f, 0.25f))
            .AppendInterval(0.1f)
            .Append(rec.DOAnchorPosY(-1200.0f, 0.75f));

        fade.SetActive(true);
        Fade.fadeout=true;
        this.gameObject.SetActive(false);
    }
}
