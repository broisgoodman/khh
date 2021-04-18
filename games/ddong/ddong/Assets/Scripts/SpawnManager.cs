using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 일정 시간마다 특정 프리팹을 복사해서 생성
/// 1. 얼마만큼의 시간인지?
/// 2. 특정 프리팹
/// 3. 어디에?-> 생성 영역 설정
/// </summary>
public class SpawnManager : MonoBehaviour
{
    

    public GameObject targetprefab;

    private float _curTime;

    // Instantiate = 복사
    private void Update()
    {
        if (Gamemanager.isGameStart == true)
        {
            if (_curTime <= 0)
            {
                //카피한 게임오브젝트가  obj 변수에 들어감
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
