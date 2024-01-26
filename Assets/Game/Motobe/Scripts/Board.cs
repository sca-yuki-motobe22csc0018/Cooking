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
    [SerializeField] private AudioSource a;

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
        sequence.Append(rec.DOAnchorPosY(1300.0f, 0))
            .Join(this.transform.DORotate(new Vector3(0, 0, -80), 0))
            .AppendCallback(() => Sound())
            .Append(rec.DOAnchorPosY(-150.0f, 0.25f))
            .Join(this.transform.DORotate(new Vector3(0, 0, 60), 0.5f))
            .SetEase(Ease.OutBounce)
            .Append(this.transform.DORotate(new Vector3(0, 0, -30), 0.75f))
            .SetEase(Ease.InOutBack)
            .Append(this.transform.DORotate(new Vector3(0, 0, 15), 1.0f))
            .SetEase(Ease.InOutBack)
            .Append(this.transform.DORotate(new Vector3(0, 0, 0), 1.25f))
            .SetEase(Ease.InOutCubic)
            .AppendInterval(0.25f)
            .Append(rec.DOAnchorPosY(0.0f, 0.25f))
            .AppendInterval(0.1f)
            .AppendCallback(() => Plays())
            .Join(rec.DOAnchorPosY(-1500.0f, 0.5f));
    }

    void Plays()
    {
        fade.SetActive(true);
        Fade.fadeout = true;
    }

    void Sound()
    {
        a.Play();
    }
}
