using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeSet : MonoBehaviour
{
    public GameObject fade;
    // Start is called before the first frame update
    void Start()
    {
        fade.SetActive(true);
        Board.open=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
