using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class TicTacTokToSelectSence : MonoBehaviour
{
    /// <summary>
    /// ���� �Ѿ� �ؼ� �޾ƿ�
    /// </summary>
    public GameObject gameResultPanel;
    /// <summary>
    /// ���� ����ߴ��� �����������
    /// </summary>
    public Text gameResultVictoryText;

    private bool isTurnO = true;

    private TicTacTokCell[,] cells = new TicTacTokCell[3, 3];

    private void Start()
    {
        gameResultPanel.SetActive(false);
    }

    public void OnClickCell(TicTacTokCell cell)
    {
        if (cell.currentState != TicTacTokCell.eState.None)
        {
            return;
        }

        if (isTurnO == true)
        {
            cell.SetState(TicTacTokCell.eState.O);
        }
        else
        {
            cell.SetState(TicTacTokCell.eState.x);
        }



        cells[cell.x, cell.y] = cell;
        CheckResult();
        isTurnO = !isTurnO;

    }


    /// <summary>
    /// ���� ����� Ȯ���ϴ� �޼ҵ�
    /// </summary>
    private void CheckResult()
    // 3���� ���޾Ƽ� ���� none�� �ƴ� state���� üũ�ؾߵ�.
    // �׷��� ���� �ʿ��� ������? ������ ��ġ �� (��� ĭ�� �ִ���)
    {
        foreach (TicTacTokCell cell in cells)
        {
            if (cell == null)
                continue;

            int sameCount = 0;

            for (int x = -2; x <= 2; x++)//�¿� ���� �˻�
            {
                if (cell.x + x < 0 || cell.x + x > 2 || cells[cell.x + x, cell.y] == null)
                    continue;

                if (cells[cell.x + x, cell.y].currentState == cell.currentState)
                {
                    sameCount += 1;
                }
            }

            if (sameCount >= 3)
            {
                GameOver();
                Debug.Log("������ �ߴܵǾ����ϴ�");
                break;
            }
            sameCount = 0;

            for (int y = -2; y <= 2; y++)//���� ���� �˻�
            {
                if (cell.y + y < 0 || cell.y + y > 2 || cells[cell.x, cell.y + y] == null)
                    continue;
                if (cells[cell.x, cell.y + y].currentState == cell.currentState)
                {
                    sameCount += 1;
                }
            }

            if (sameCount >= 3)
            {
                GameOver();
                Debug.Log("������ �ߴܵǾ����ϴ�");
                break;
                
            }
            sameCount = 0;


            // for (int x = -2, y= -2; x <= 2 && y <= 2; x++, y++)// ��� �밢�� ���� �˻�
            // {
            //     if (cell.y + y < 0 || cell.y + y > 2 || cells[cell.x, cell.y + y] == null || cell.x + x < 0 || cell.x + x > 2 || cells[cell.x + x, cell.y] == null)
            //          continue;

            //  if (cells[cell.x + x,cell.y + y].currentState == cell.currentState)
            //  {
            //    sameCount += 1;
            //  }


            //   if (sameCount >= 3)
            //   {
            //       Debug.Log("������ �ߴܵǾ����ϴ�");
            //        break;
            //    }
            //     sameCount = 0;
            //  }

        }


    }
    private void GameOver()
    {
        gameResultVictoryText.text = string.Format(gameResultVictoryText.text, isTurnO == true ? "O" : "X");

        gameResultPanel.SetActive(true);
     }

    public void OnClickGoToSelect()
    {
        SceneManager.LoadScene("Scenes/2SelectGameScene");
    }
}
