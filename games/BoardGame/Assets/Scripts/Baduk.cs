using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Baduk : MonoBehaviour
{
    public void OnClickGoToSelect()
    {
        SceneManager.LoadScene("Scenes/2SelectGameScene");
    }
}
