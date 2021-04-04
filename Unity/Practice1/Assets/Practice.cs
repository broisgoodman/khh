using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Practice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("일반 로그");
        Debug.LogWarning("경고 로그");
        Debug.LogError("에러 로그");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) == true)
       {
            Debug.Log("W가 눌렸다");
        }

        if (Input.GetKeyDown(KeyCode.A) == true)
        {
            Debug.Log("A가 눌렸다");
        }

        if (Input.GetKeyDown(KeyCode.S) == true)
        {
            Debug.Log("S가 눌렸다");
        }
        
        if (Input.GetKeyDown(KeyCode.D) == true)
        {
            Debug.Log("D가 눌렸다");
        }

        if (Input.GetKeyDown(KeyCode.D)&Input.GetKey(KeyCode.LeftControl) == true)
        {
            Debug.Log("컨트롤 D가 눌렸다");
        }
    }
}
