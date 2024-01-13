using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;



public class NewBehaviourScript : MonoBehaviour
{
    public Ease ease = Ease.Linear;
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        transform.DOMove(target.position, 10.0f)
            .SetEase(ease)
            .OnStart(OnStart)
            .OnComplete(OnComplete)
            .OnKill(OnKill);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)) {
            this.transform.DOKill();
        }
    }

    void OnStart() {
        Debug.Log("tween start");
    }

    void OnComplete() {
        Debug.Log("tween end");
    }

    void OnKill() {
        Debug.Log("tween killed");
    }
}
