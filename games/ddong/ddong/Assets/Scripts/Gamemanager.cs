using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gamemanager : MonoBehaviour
{
    private static bool isInit = false;
    public static bool isGameStart = false;
    public static int score = 0;




    private void Start()
    {
        score = 0;
        isGameStart = false;

        if (isInit == false)
        {
            DontDestroyOnLoad(this.gameObject);
            isInit = true;
        }
        else
        {
            Destroy(this.gameObject);
        }

       

    }

    

    public void LoadGameScene()
    {
        SceneManager.LoadScene("Scenes/Game");
        isGameStart = true;
    }
}
