using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleMove : MonoBehaviour
{
    public float nowPos;

    void Start()
    {
        nowPos = this.transform.position.y;
    }
    void Update()
    {
        transform.position = new Vector3(transform.position.x, nowPos + Mathf.PingPong(Time.time/3, 0.3f), transform.position.z);
    }
}
