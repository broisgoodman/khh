using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Title : MonoBehaviour
{
    public Text tweenTarget;
    private void Start()
    {
        StartCoroutine(TweenAnimation());
       // StopCoroutine(TweenAnimation());
      
    }

    private void Update()
    {
        if (Input.anyKeyDown == true) //아무키나 눌렸을 때
        {
            SceneManager.LoadScene("Scenes/2SelectGameScene");             // 게임 선택씬으로 이동

        }
    }



    // 코루틴
    // Update문 (반복문) 안에서 실행시키면 안된다.
    private IEnumerator TweenAnimation()
    {
        
        tweenTarget.color = new Color(tweenTarget.color.r, tweenTarget.color.g, tweenTarget.color.b, 0.5f); //투명도 50% 적용
        float alpha = tweenTarget.color.a;

        while(true)
        {

            tweenTarget.color = new Color(tweenTarget.color.r, tweenTarget.color.g, tweenTarget.color.b, alpha); //투명도 50% 적용

            yield return null;

            if (alpha >= 1)
            { alpha = 0.5f; }

                alpha += 0.5f * Time.deltaTime;
            
        }


    }
}
