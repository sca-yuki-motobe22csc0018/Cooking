using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class BoardCheck : MonoBehaviour
{
    public Image board;
    RectTransform rec;

    // Start is called before the first frame update
    void Start()
    {
        board = GetComponent<Image>();
        rec = GetComponent<RectTransform>();
        move();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void move()
    {
        var sequence = DOTween.Sequence();
        sequence.Append(rec.DOAnchorPosY(1300.0f, 0))
            .Join(this.transform.DORotate(new Vector3(0, 0, -80), 0))
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
            .Append(rec.DOAnchorPosY(-1500.0f, 0.5f));
    }
}
