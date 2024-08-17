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
    public int a;
    public GameObject b;
    // Start is called before the first frame update
    void Start()
    {
        if (b != null)
        b.gameObject.SetActive(false);
        maxSize = 1.1f;
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
            //    //if (a == 1)
            //    //{
            //    //    b.SetActive(true);
                //}
            }
            if (b != null)
            {
                if (a==1 && ScoreSet.Star >= 1)
                { 
                    b.SetActive(true);
                }
                if (a == 2&&ScoreSet.Star>=2)
                {
                    b.SetActive(true);
                }
                if (a == 3 && ScoreSet.Star >= 3)
                {
                    b.SetActive(true);
                }
            }
        }
    }
}
