using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HellChange : MonoBehaviour
{
    public GameObject hell;
    int a;
    [SerializeField] private AudioSource audio;
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
        if (a==10)
        {
            hell.SetActive(true);
            audio.Play();
            if (this.tag == "hell"||this.tag=="hell2")
            {
                a = 0;
                this.gameObject.SetActive(false);
                
            }
            
        }
    }
}
