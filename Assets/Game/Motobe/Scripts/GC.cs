using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GC : MonoBehaviour
{
    public GameObject Pt1;
    public GameObject Pt2;
    // �ʒu���W
    private Vector3 position;
    // �X�N���[�����W�����[���h���W�ɕϊ������ʒu���W
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
            
            // Vector3�Ń}�E�X�ʒu���W���擾����
            position = Input.mousePosition;
            // Z���C��
            position.z = 10f;
            // �}�E�X�ʒu���W���X�N���[�����W���烏�[���h���W�ɕϊ�����
            screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(position);
            // ���[���h���W�ɕϊ����ꂽ�}�E�X���W����
            Pt1.transform.position = screenToWorldPointPosition;
            Pt2.transform.position = screenToWorldPointPosition;
            Instantiate(Pt1);
            Instantiate(Pt2);
        }
    }
}
