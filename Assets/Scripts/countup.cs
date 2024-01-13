using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class countup : MonoBehaviour
{
    public Text valueText;
    private int currentValue = 10000;
    // Start is called before the first frame update
    void Start()
    {
        currentValue = 10000;
        valueText.text = currentValue.ToString();

        DOTween.To(() => currentValue, 
                (val) => { 
                    currentValue = val;
                    valueText.text = val.ToString();
                },
                0,
                10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
