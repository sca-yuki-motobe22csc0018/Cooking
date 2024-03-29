using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GC : MonoBehaviour
{
    public GameObject Pt1;
    public GameObject Pt2;
    public GameObject Pt3;
    public GameObject Pt4;
    // 位置座標
    private Vector3 position;
    // スクリーン座標をワールド座標に変換した位置座標
    private Vector3 screenToWorldPointPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            // Vector3でマウス位置座標を取得する
            position = Input.mousePosition;
            // Z軸修正
            position.z = 10f;
            // マウス位置座標をスクリーン座標からワールド座標に変換する
            screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(position);
            // ワールド座標に変換されたマウス座標を代入
            Pt1.transform.position = screenToWorldPointPosition;
            Pt2.transform.position = screenToWorldPointPosition;
            Pt3.transform.position = screenToWorldPointPosition;
            Pt4.transform.position = screenToWorldPointPosition;
            Instantiate(Pt1);
            Instantiate(Pt2);
            Instantiate(Pt3);
            Instantiate(Pt4);
        }
    }
}
