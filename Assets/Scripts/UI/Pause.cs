using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public GameObject pause;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && !pause.activeSelf)
        {
            pauseGame();
        }
    }

    public void pauseGame()
    {
        Time.timeScale = 0;
        pause.SetActive(true);
    }
}
