using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clear : MonoBehaviour
{
    public GameObject score_object = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text score_text = score_object.GetComponent<Text>();
        if (ClearCount.score_num < 10)
        {
            score_text.text = "Clear:  " + ClearCount.score_num;
        }
        else
        {
            score_text.text = "Clear: " + ClearCount.score_num;
        }
    }
}
