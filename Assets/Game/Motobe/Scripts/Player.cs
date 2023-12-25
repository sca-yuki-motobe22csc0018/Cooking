using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float sin;
    public GameObject my;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sin=Mathf.Sin(Time.time);
        my.transform.position=new Vector3(70,0,0);
    }
}
