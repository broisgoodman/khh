using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class TicTacTokToSelectSence : MonoBehaviour
{
    /// <summary>
    /// 껐다 켜야 해서 받아옴
    /// </summary>
    public GameObject gameResultPanel;
    /// <summary>
    /// 누가 우승했는지 수정해줘야함
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
    /// 게임 결과를 확인하는 메소드
    /// </summary>
    private void CheckResult()
    // 3개가 연달아서 같은 none이 아닌 state인지 체크해야됨.
    // 그러기 위해 필요한 데이터? 셀들의 위치 값 (몇번 칸에 있는지)
    {
        foreach (TicTacTokCell cell in cells)
        {
            if (cell == null)
                continue;

            int sameCount = 0;

            for (int x = -2; x <= 2; x++)//좌우 라인 검사
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
                Debug.Log("게임이 중단되었습니다");
                break;
            }
            sameCount = 0;

            for (int y = -2; y <= 2; y++)//상하 라인 검사
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
                Debug.Log("게임이 중단되었습니다");
                break;
                
            }
            sameCount = 0;


            // for (int x = -2, y= -2; x <= 2 && y <= 2; x++, y++)// 상승 대각선 라인 검사
            // {
            //     if (cell.y + y < 0 || cell.y + y > 2 || cells[cell.x, cell.y + y] == null || cell.x + x < 0 || cell.x + x > 2 || cells[cell.x + x, cell.y] == null)
            //          continue;

            //  if (cells[cell.x + x,cell.y + y].currentState == cell.currentState)
            //  {
            //    sameCount += 1;
            //  }


            //   if (sameCount >= 3)
            //   {
            //       Debug.Log("게임이 중단되었습니다");
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
