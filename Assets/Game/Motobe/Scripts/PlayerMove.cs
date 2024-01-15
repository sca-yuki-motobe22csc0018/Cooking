using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    float cos;
    // Start is called before the first frame update
    void Start()
    {
        cos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        cos = Mathf.Cos(Time.time);
        this.transform.position += new Vector3(0, cos/1500, 0);
    }
}
