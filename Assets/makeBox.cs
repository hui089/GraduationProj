using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeBox : MonoBehaviour
{
    public GameObject box;
    float timer=0;
    public float timediff;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timediff)
        {
            Instantiate(box); //�ڽ� ����
            timer = 0; //1�ʸ��� ������ ���� 
        }

    }
}
