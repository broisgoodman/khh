using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("�Ϲ� �α�");
        Debug.LogWarning("��� �α�");
        Debug.LogError("���� �α�");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) == true)
       {
            Debug.Log("W�� ���ȴ�");
        }

        if (Input.GetKeyDown(KeyCode.A) == true)
        {
            Debug.Log("A�� ���ȴ�");
        }

        if (Input.GetKeyDown(KeyCode.S) == true)
        {
            Debug.Log("S�� ���ȴ�");
        }
        
        if (Input.GetKeyDown(KeyCode.D) == true)
        {
            Debug.Log("D�� ���ȴ�");
        }

        if (Input.GetKeyDown(KeyCode.D)&Input.GetKey(KeyCode.LeftControl) == true)
        {
            Debug.Log("��Ʈ�� D�� ���ȴ�");
        }
    }
}
