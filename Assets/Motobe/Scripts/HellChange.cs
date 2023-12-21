using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HellChange : MonoBehaviour
{
    public GameObject hell;
    int a;
    // Start is called before the first frame update
    void Start()
    {
        a=0;
        hell.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UP()
    {
        a+=1;
        if (a>10)
        {
            hell.SetActive(true);
        }
    }
}
