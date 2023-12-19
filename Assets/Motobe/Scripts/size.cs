using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class size : MonoBehaviour
{
    float sin;
    public float speedchange;
    public float sizechange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sin = Mathf.Sin(Time.time*speedchange);
        this.gameObject.transform.localScale = new Vector3(sin * sizechange + 1, sin * sizechange + 1, 1);
    }
}
