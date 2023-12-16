using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class size : MonoBehaviour
{
    float sin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sin = Mathf.Sin(Time.time*8);
        this.gameObject.transform.localScale = new Vector3(sin * 0.2f + 1, sin * 0.2f + 1, 1);
    }
}
