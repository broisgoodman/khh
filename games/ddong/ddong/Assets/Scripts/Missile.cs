using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 미사일을 관리하는 스크립트
/// 1. 미사일이 특정 지점에 도달하면 삭제 v
/// 2. 플레이어 충돌 감지 
/// </summary>
public class Missile : MonoBehaviour
{ 
       // Update is called once per frame
    void Update()
    {
        CheckDeadLine();

    }
    void CheckDeadLine()
    {
        if(this.transform.position.y < -5)
        {
            //Destroy(this.); -> 스크립트 삭제
            Gamemanager.score += 100;
            UIManager.Instance.scoreLabel.text = Gamemanager.score.ToString();
            Destroy(this.gameObject);
        }
    }
   // private void OnCollisionEnter2D(Collision2D collision)
    
    private void OnTriggerEnter2D(Collider2D collision) //exit, 등등 존재
    {
        if (collision.tag == "Player")
        {
            
            OnHit();
        }
    }
    void OnHit()
    {//사망 조건이 있으면 여기 추가
        UIManager.Instance.ShowGameOverUI();
        Destroy(this.gameObject);
    }
}
