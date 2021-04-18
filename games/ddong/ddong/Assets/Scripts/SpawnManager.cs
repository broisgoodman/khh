using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// ���� �ð����� Ư�� �������� �����ؼ� ����
/// 1. �󸶸�ŭ�� �ð�����?
/// 2. Ư�� ������
/// 3. ���?-> ���� ���� ����
/// </summary>
public class SpawnManager : MonoBehaviour
{
    

    public GameObject targetprefab;

    private float _curTime;

    // Instantiate = ����
    private void Update()
    {
        if (Gamemanager.isGameStart == true)
        {
            if (_curTime <= 0)
            {
                //ī���� ���ӿ�����Ʈ��  obj ������ ��
                GameObject obj = Instantiate(targetprefab);
                obj.transform.position = new Vector3(Random.Range(-10f, 10f), 10, 0);
                Rigidbody2D targetRigid = obj.GetComponent<Rigidbody2D>();
                targetRigid.gravityScale = Random.Range(1f, 3f);
                _curTime = Random.Range(0.1f, 1f); //0.1~2

            }

            else
            {
                _curTime -= Time.deltaTime;
            }
        }
    }


}
