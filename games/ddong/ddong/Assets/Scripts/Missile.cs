using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// �̻����� �����ϴ� ��ũ��Ʈ
/// 1. �̻����� Ư�� ������ �����ϸ� ���� v
/// 2. �÷��̾� �浹 ���� 
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
            //Destroy(this.); -> ��ũ��Ʈ ����
            Gamemanager.score += 100;
            UIManager.Instance.scoreLabel.text = Gamemanager.score.ToString();
            Destroy(this.gameObject);
        }
    }
   // private void OnCollisionEnter2D(Collision2D collision)
    
    private void OnTriggerEnter2D(Collider2D collision) //exit, ��� ����
    {
        if (collision.tag == "Player")
        {
            
            OnHit();
        }
    }
    void OnHit()
    {//��� ������ ������ ���� �߰�
        UIManager.Instance.ShowGameOverUI();
        Destroy(this.gameObject);
    }
}
