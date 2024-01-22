using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StartSize : MonoBehaviour
{
    float maxSize;
    float size;
    float speed;
    public GameObject next;
    // Start is called before the first frame update
    void Start()
    {
        maxSize = 1.0f;
        size = 0;
        if(next != null)
        next.SetActive(false);
        speed = 0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (size < maxSize)
        {
            this.gameObject.transform.localScale = new Vector3(size, size, 0);
            size += speed;
        }
        if (size >= maxSize)
        {
            if (next != null)
            {
                next.SetActive(true);
            }
        }
    }
}
