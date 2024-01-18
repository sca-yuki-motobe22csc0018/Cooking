using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ClearTime : MonoBehaviour
{
    public GameObject time_object = null;
    int min;
    int sec;
    // Start is called before the first frame update
    void Start()
    {
        sec=GameController.TimeSet%60;
        min=GameController.TimeSet/60;
        Debug.Log(min+":"+sec);
    }

    // Update is called once per frame
    void Update()
    {
        Text time_text = time_object.GetComponent<Text>();
        if (GameController.TimeSet>=600)
        {
            time_text.text = "Time.  9:59";
        }else if(sec>10)
        {
            time_text.text = "Time.  "+ min + ":" + sec;
        }
        else
        {
            time_text.text = "Time.  " + min + ":0" + sec;
        }

    }
    //Time.  5:00
}
