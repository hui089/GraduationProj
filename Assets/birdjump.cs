using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdjump : MonoBehaviour
{
    Rigidbody2D rb; //���� ����
    
    // Start is called before the first frame update
    void Start() //��ó�� ����ɶ� �ѹ���
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() //�� �����Ӹ��� ����
    {
        if(Input.GetMouseButtonDown(0)) //���콺 ���� ��ư ������ ��
        {
            rb.velocity = Vector2.up * 3 ; //(0,1)
        }
    }
}
