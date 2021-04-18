using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour
{
    public Gamemanager manager;
    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            manager.LoadGameScene();
            Destroy(this);
        }
    }
}
