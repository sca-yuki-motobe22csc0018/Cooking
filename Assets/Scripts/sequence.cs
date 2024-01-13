using UnityEngine;
using DG.Tweening;

public class sequence : MonoBehaviour
{
    private Sequence _sequence;
    // Start is called before the first frame update
    void Start()
    {
        makeSequence();
    }

    private void Update() {
        
    }
    void onRotateStart() {
        Debug.Log("rotate start");
    }

    void onMoveStart() {
        Debug.Log("move start");
    }

    void onJumpStart() {
        Debug.Log("jump start");
    }

    void onCmplete() {
        makeSequence();
    }

    void makeSequence() {
        _sequence = DOTween.Sequence();
        _sequence.Append(this.transform.DORotate(new Vector3(0, 90, 0), 1.0f)
                                       .OnStart(onRotateStart));
        _sequence.Append(this.transform.DOJump(new Vector3(4, 0, 0), 1.0f, 1, 5.0f)
                                       .OnStart(onJumpStart));
        _sequence.Append(this.transform.DORotate(new Vector3(0, 0, 0), 1.0f)
                                       .OnStart(onRotateStart));
        _sequence.Append(this.transform.DOMove(new Vector3(4, 0, 4), 5.0f)
                                       .OnStart(onMoveStart));
        _sequence.Append(this.transform.DORotate(new Vector3(0, -90, 0), 1.0f)
                                       .OnStart(onRotateStart));
        _sequence.Append(this.transform.DOJump(new Vector3(0, 0, 4), 1.0f, 1, 5.0f)
                                       .OnStart(onJumpStart));
        _sequence.Append(this.transform.DORotate(new Vector3(0, -180, 0), 1.0f)
                                       .OnStart(onRotateStart));
        _sequence.Append(this.transform.DOMove(new Vector3(0, 0, 0), 5.0f)
                                       .OnStart(onMoveStart));
        _sequence.Append(this.transform.DORotate(new Vector3(0, 0, 0), 1.0f)
                                       .OnStart(onRotateStart)
                                       .OnComplete(onCmplete));
        _sequence.Play();
    }

}
