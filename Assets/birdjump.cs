using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdjump : MonoBehaviour
{
    Rigidbody2D rb; //변수 선언
    
    // Start is called before the first frame update
    void Start() //맨처음 실행될때 한번만
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() //매 프레임마다 실행
    {
        if(Input.GetMouseButtonDown(0)) //마우스 왼쪽 버튼 눌렀을 때
        {
            rb.velocity = Vector2.up * 3 ; //(0,1)
        }
    }
}
