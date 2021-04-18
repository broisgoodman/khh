using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// �÷��̾� ����� ����ϴ� Ŭ����
/// - ������ ����
/// </summary>
/// 1���� �޼ҵ尡 1���� ����� ���. -> oop��Ģ(����å�ӿ�Ģ)
public class Player : MonoBehaviour
{
    public float moveSpeed;

    Vector2 resultMoveDelta;

    void Update()
    {
        CheckMove();
    }
    void CheckMove()
    {
        
        resultMoveDelta = Vector2.zero;
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            resultMoveDelta += Vector2.left;
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            resultMoveDelta += Vector2.right;

        }

        ///ĳ���� ������
        //������-������ �� �ɸ� �ð�
        //Time.deltatime�� ���Ѵ� -> '�ʴ�'�� �ǹ�
        transform.position += (Vector3)resultMoveDelta * moveSpeed * Time.deltaTime;

    }

}
