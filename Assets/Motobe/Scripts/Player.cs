using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float sin;
    public RectTransform my;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sin=Mathf.Sin(Time.time);
        my.transform.position=new Vector3(960+685,sin*20+560,0);
    }
}
