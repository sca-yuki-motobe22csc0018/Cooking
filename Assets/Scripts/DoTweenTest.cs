using UnityEngine;
using DG.Tweening;

public enum tween_kind
{
    move,
    jump,
    rotate,
    lookat,
    scale
}


public class DoTweenTest : MonoBehaviour
{
    public tween_kind kind;
    public Transform target;
    public Vector3 rotate;
    public Vector3 scale = new Vector3(1, 1, 1);
    public float duration = 1.0f;
    public float jumpPower = 1.0f;
    public int jumpTime = 1;
    public LoopType loopType;
    public int loopTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        switch(kind) {
            case tween_kind.move :
                transform.DOMove(target.position, duration)
                                .SetEase(Ease.Linear)
                                .SetLoops(loopTime,loopType);
                break;
            case tween_kind.jump :
                transform.DOJump(target.position, jumpPower, jumpTime, duration);
                break;
            case tween_kind.rotate :
                transform.DORotate(rotate, duration);
                break;
            case tween_kind.lookat :
                transform.DOLookAt(target.position, duration);
                break;
            case tween_kind.scale :
                transform.DOScale(scale, duration);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
